using ItemDB.DB;
using ItemDB.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ItemDB
{
	public partial class MainForm : Form
	{

		#region Поля и свойства

		/// <summary>
		/// База данных.
		/// </summary>
		private DBRecord DB;

		#endregion

		#region Интерфейс формы и ее события

		/// <summary>
		/// Загрузка формы.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Данные события.</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadDB();
		}

		/// <summary>
		/// Нажатие на кнопку добавить.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Данные события.</param>
		private void bt_Add_Click(object sender, EventArgs e)
		{
			AddRecord();
		}

		/// <summary>
		/// Изменения текста в пойсковой строке с "Наименования предмета".
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Данные события.</param>
		private void tb_Name_TextChanged(object sender, EventArgs e)
		{
			FilterSearch();
		}

		/// <summary>
		/// Изменения текста в пойсковой строке с  ФИО.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Данные события.</param>
		private void tb_FIO_TextChanged(object sender, EventArgs e)
		{
			FilterSearch();
		}

		/// <summary>
		/// Запрашивает таблицу из БД занова.
		/// </summary>
		/// <param name="sender">Отправитель.</param>
		/// <param name="e">Данные события.</param>
		private void bt_Reload_Click(object sender, EventArgs e)
		{
			DB.ReloadList();
			RefreshList(DB.rows);
		}
		#endregion

		#region Методы

		/// <summary>
		/// Подключение к БД.
		/// </summary>
		private void LoadDB()
		{
			DB = new DBRecord();
			DB.Connect();
			RefreshList(DB.rows);
		}

		/// <summary>
		/// Добавление записи в БД.
		/// </summary>
		private void AddRecord()
		{
			if (!string.IsNullOrEmpty(tbAdd_FIO.Text) && !string.IsNullOrEmpty(tbAdd_Name.Text))
			{
				if(tbAdd_CodeClass.Text.Length == 6 && int.TryParse(tbAdd_CodeClass.Text, out int CodeClass))
				{
					if(tbAdd_CodeRegistr.Text.Length == 3 && int.TryParse(tbAdd_CodeRegistr.Text, out int CodeRegis))
					{
						if (DB.SearchCodeRegisterNumber(CodeClass,CodeRegis,out string IspNumber))
						{
							Record record = new Record();
							record.Name = tbAdd_Name.Text;
							record.FIO = tbAdd_FIO.Text;
							record.DecimalNumber = $"ИЗИС.{tbAdd_CodeClass.Text}.{tbAdd_CodeRegistr.Text}-{IspNumber}";
							record.DataAdd = DateTime.Today;
							DB.AddRecord(record);
							label_DecimalNumber.Text = record.DecimalNumber;
							label_DataAdd.Text = $"от - {record.DataAdd.ToShortTimeString()}";
							DB.ReloadList();
							RefreshList(DB.rows);
						}
						else
						{
							MessageBox.Show("Данный регистрациионный номер не был присвоен ранее, присвойте его чтобы добавить исполнение.");
						}
					}
					else if (string.IsNullOrEmpty(tbAdd_CodeRegistr.Text))
					{
						Record record = new Record();
						record.Name = tbAdd_Name.Text;
						record.FIO = tbAdd_FIO.Text;
						record.DecimalNumber = $"ИЗИС.{tbAdd_CodeClass.Text}.{DB.SearchCodeClassNumber(CodeClass)}";
						record.DataAdd = DateTime.Today;
						DB.AddRecord(record);
						label_DecimalNumber.Text = record.DecimalNumber;
						label_DataAdd.Text = $"от - {record.DataAdd.ToShortTimeString()}";
						DB.ReloadList();
						RefreshList(DB.rows);
					}
					else
					{
						MessageBox.Show("Ошибка проверте правильность введенного порядкогового номера.","Error");
					}
				}
				else
				{
					MessageBox.Show("Код классификационной характеристики введен не полностью\n" +
						"Он должен иметь вид \"406231\", где" +
						"40.... - Это \"Средства измерений линейных и угловых размеров, параметров ...\".\n" +
						"406... - Это \"Средства измерения давления и преобразования в давление расхода и уровня\".\n" +
						"4062.. - Это \"Датчик(преобразования и приборы с электрическими сигналами (выходными, входными;)\".\n" +
						"40623. - Это \"Электрические\".n" +
						"406231 - Это \"Пьезоэлектрические\".\n");
				}
			}
			else
			{
				MessageBox.Show("Введите коретное название и ваше ФИО");
			}
		}

		/// <summary>
		/// Выводит в ListView переданный список.
		/// </summary>
		/// <param name="list">Список полученных записей.</param>
		private void RefreshList(List<Record> list)
		{
			listView_Data.Items.Clear();
			listView_Data.Items.Add(new ListViewItem(""));
			foreach (Record record in list)
			{
				string[] row = new string[]
				{
					record.SerialNumber.ToString(),
					record.DecimalNumber,
					record.Name,
					record.FIO,
					record.DataAdd.ToShortDateString()
				};
				listView_Data.Items.Add(new ListViewItem(row));
			}
		}

		/// <summary>
		/// Пойск по ФИО и наименованию предмета. 
		/// </summary>
		private void FilterSearch()
		{
			try
			{
				if (!string.IsNullOrEmpty(tb_FIO.Text) && !string.IsNullOrEmpty(tb_Name.Text))
				{
					DB.FilteredList = DB.rows.Where((row) =>
					(row.FIO.ToLower().Contains(tb_FIO.Text.ToLower())) &&
					(row.Name.ToLower().Contains(tb_Name.Text.ToLower())))
						.ToList();
					RefreshList(DB.FilteredList);
				}
				else if (string.IsNullOrEmpty(tb_FIO.Text) && !string.IsNullOrEmpty(tb_Name.Text))
				{
					DB.FilteredList = DB.rows.Where((row) =>
					row.Name.ToLower().Contains(tb_Name.Text.ToLower()))
						.ToList();
					RefreshList(DB.FilteredList);
				}
				else if (!string.IsNullOrEmpty(tb_FIO.Text) && string.IsNullOrEmpty(tb_Name.Text))
				{
					DB.FilteredList = DB.rows.Where((row) =>
					row.FIO.ToLower().Contains(tb_FIO.Text.ToLower()))
						.ToList();
					RefreshList(DB.FilteredList);
				}
				else
					RefreshList(DB.rows);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR");
			}
		}
		#endregion

		#region Фичи

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Закрыть?\nВы уверенны что хотите завершить работу программы?", "WHY DO YOU CALL?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}
		private void tbAdd_CodeRegistr_TextChanged(object sender, EventArgs e)
		{
			if (tbAdd_CodeRegistr.Text.Length > 3)
			{
				MessageBox.Show("Код порядкового регистрационного номера должен имеет длинну 3 знака");
			}
		}

		private void tbAdd_CodeClass_TextChanged(object sender, EventArgs e)
		{
			if (tbAdd_CodeClass.Text.Length > 6)
			{
				MessageBox.Show("Код классификационной характеристики должен имеет длинну 6 знаков");
			}
		}

		private void listView_Data_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			this.listView_Data.Cursor = Cursors.Default;
			e.NewWidth = this.listView_Data.Columns[e.ColumnIndex].Width;
			e.Cancel = true;
		}
		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор формы.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}
		#endregion

		#region NOT USED

		#endregion
	}
}
