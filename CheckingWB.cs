using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goparceyourself
{
    public partial class CheckingWB : UserControl
    {
        public CheckingWB()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Отметить выбранным
        /// </summary>
        public bool Check()
        {
            this.checkBox1.Checked = true;
            return true;
        }

        /// <summary>
        /// Отменить выбор
        /// </summary>
        public bool Uncheck()
        {
            this.checkBox1.Checked = false;
            return false;
        }

        /// <summary>
        /// Источник картинки
        /// </summary>
        /// <param name="url"></param>
        public void source(Uri url)
        {
            this.webControl1.Source = url;
        }

    }
}
