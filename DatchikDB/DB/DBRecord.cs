using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ItemDB.DB
{
  /// <summary>
  /// База данных.
  /// </summary>
  internal class DBRecord
  {
		#region Поля и свойства

		/// <summary>
		/// Строка подключения.
		/// </summary>
		private SqlConnection sqlConnection;
    
    /// <summary>
    /// Таблица изначальных данных.
    /// </summary>
    public List<Record> rows;
    
    /// <summary>
    /// Отсортированный список.
    /// </summary>
    public List<Record> FilteredList;
		#endregion

		#region Методы

		/// <summary>
		/// Подключение к баз данных, пока что локальной БД.
		/// </summary>
		public void Connect()
    {
      try
      {
        this.sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString);
				this.sqlConnection.Open();
        if (this.sqlConnection.State == ConnectionState.Open)
        {
          MessageBox.Show("Подключеие к базе данных установлено!");
          ReloadList();
				}
        else
          throw new Exception("Ошибка подключения к базе данных.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }
    
    /// <summary>
    /// Запрос всех записей из БД.
    /// </summary>
    public void ReloadList()
    {
			this.rows = new List<Record>();
			Record row;
      SqlCommand sqlCommand = new SqlCommand(
        "SELECT * FROM RecordTable",
        this.sqlConnection);
      if(sqlCommand == null) throw new ArgumentNullException("Переданна пустой БД.");
			SqlDataReader dataReader = sqlCommand.ExecuteReader();
      while (dataReader.Read()) 
      {
        row = new Record();
        row.SerialNumber = Convert.ToInt32(dataReader["SerialNumber"]);
				row.DecimalNumber = Convert.ToString(dataReader["DecimalNumber"]);
        row.Name = Convert.ToString(dataReader["Name"]);
        row.FIO = Convert.ToString(dataReader["FIO"]);
        row.DataAdd = Convert.ToDateTime(dataReader["DataAdd"]);
				this.rows.Add(row);
      }
    }
    
    /// <summary>
    /// Создает в БД новую запись.
    /// </summary>
    /// <param name="record">Новая запись.</param>
    public void AddRecord(Record record)
    {
      if (record == null) throw new ArgumentNullException("Переданна пустая запись.");
      SqlCommand command = new SqlCommand(
      $"INSERT INTO [RecordTable] (DecimalNumber, Name, FIO, DataAdd) VALUES(@DecimalNumber, @Name, @FIO, @DataAdd)"
      , this.sqlConnection);
      command.Parameters.AddWithValue("DecimalNumber", record.DecimalNumber);
      command.Parameters.AddWithValue("Name", record.Name);
      command.Parameters.AddWithValue("FIO", record.FIO);
      command.Parameters.AddWithValue("DataAdd", record.DataAdd.Date);
      MessageBox.Show("Добавленных записей - " + command.ExecuteNonQuery().ToString() + $"\n{record.DataAdd.ToShortDateString()} был добавлен предмет\n{record.Name}\nс децимальным номером {record.DecimalNumber}");
    }
    
    /// <summary>
    /// Перебирает список, ищет количество записей с переданным кодом классификации.
    /// </summary>
    /// <param name="CatalogNumber">Код классификационной характеристки.(000000)</param>
    /// <returns>Возращает количество записей с таким же кодом классификации, или 1 если записей не было.</returns>
    /// <exception cref="ArgumentNullException">Отсутвует подключение к баз данных.</exception>
    public string SearchCodeClassNumber(int CatalogNumber)
    {
      if (CatalogNumber < 0 )
        throw new ArgumentOutOfRangeException("Переданный код классификации не существует.");
      if (this.sqlConnection != null)
      {
        if (this.rows.Any())
        {
          string codeClass = string.Format("{0:d6}",CatalogNumber);
          var calagGroup = this.rows
            .Where(row => (row.DecimalNumber.Split('.')[1] == codeClass)&&(!row.DecimalNumber.Contains('-')))
            .Count();
          return string.Format("{0:d3}",calagGroup + 1);
        }
        else
        {
          return "001";
        }
      }
      else
        throw new ArgumentNullException("Отсутсвует подключение к базе данных.", "Ошибка");
    }

		/// <summary>
		/// Перебирает список, ищет количество записей с переданным кодом классификации и кодом порядкового регистрациооного номера. Возвращает номер исполнения по порядку.
		/// </summary>
		/// <param name="CatalogNumber">Код классификационной характеристки.(000000)</param>
		/// <param name="CodeRegister">Код порядкового регистрациооного номера.(000)</param>
		/// <param name="result">Номер исполнения.(00)</param>
		/// <returns>True, если был найдено больше 1 Децимального номера с данным кодом классфикационной характеристики и с данным регистрациионным порядковым номером, в противном случае false.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Список пуст, нельзя присвоить исполнение без присваеваение кода регистрации раньше.</exception>
		/// <exception cref="ArgumentNullException">"Отсутсвует подключение к базе данных.", "Ошибка"</exception>
		public bool SearchCodeRegisterNumber(int CatalogNumber, int CodeRegister , out string result)
		{
			if (CatalogNumber < 0 || CodeRegister < 0)
				throw new ArgumentOutOfRangeException("Переданный код классификации не существует.");
			if (this.sqlConnection != null)
			{
        result = "01";
				if (this.rows.Any())
				{
					string codeClass = string.Format("{0:d6}", CatalogNumber);
          string codeRegis = string.Format("{0:d3}", CodeRegister);
					var calagGroup = this.rows
						.Where(row => row.DecimalNumber.Split('.')[1] == codeClass 
            && row.DecimalNumber.Split('.')[2].Split('-')[0] == codeRegis)
						.Count();
          if(calagGroup > 0)
          {
					  result = string.Format("{0:d2}", calagGroup + 1);
            return true;
          }
          else
            return false;
				}
				else
				{
          throw new ArgumentNullException("Список пуст, нельзя присвоить исполнение без присваеваение кода регистрации раньше. ");
				}
			}
			else
				throw new ArgumentNullException("Отсутсвует подключение к базе данных.", "Ошибка");
		}
		#endregion

		#region Конструкторы

		/// <summary>
		/// Созадаем экземпляр.
		/// </summary>
		public DBRecord()
    {
      this.rows = new List<Record> ();
    }
		#endregion
	}
}
