using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ItemDB.DB
{
	public class Record
	{
		#region Поля и свойства
		/// <summary>
		/// Порядковый номер или ID, уникальный ключ.
		/// </summary>
		public int SerialNumber { get; set; }

		/// <summary>
		/// Децимальный номер (ИЗИС.000000.001).
		/// </summary>
		public string DecimalNumber { get; set; }

		/// <summary>
		/// Название предмета.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Кто добавил.
		/// </summary>
		public string FIO {  get; set; }

		/// <summary>
		/// Дата добавления.
		/// </summary>
		public DateTime DataAdd {  get; set; }
		#endregion
	}
}
