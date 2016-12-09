using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace goparceyourself
{
    public partial class Sizes : Form
    {
        public Sizes()
        {
            InitializeComponent();
        }
        List<TextBox> new_choices = new List<TextBox>();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
            int y = 0;

            for (int i = Application.OpenForms[0].Controls.Count-1; i >= 0; i--)
            {
                if (Application.OpenForms[0].Controls[i] is TextBox && Application.OpenForms[0].Controls[i].Name.Contains("choice") && Application.OpenForms[0].Controls[i].Name != "choice_type")
                {
                    Application.OpenForms[0].Controls.RemoveAt(i);
                }
            }


            for (int n = 0; n < dataGridView1.RowCount - 1; n++)
            {
                try
                {
                    if (dataGridView1[dataGridView1.CurrentCell.ColumnIndex, n].Value.ToString() != String.Empty)
                    {
                        TextBox choice = new TextBox();
                        new_choices.Add(choice);
                        choice.Name = "choice" + (n + 1).ToString();
                        choice.Text = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, n].Value.ToString();
                        choice.Location = new Point(835 + x, 88 + y);

                        if (new_choices.Count % 8 == 0)
                        {
                            x += 142;
                            y = 0;
                        }
                        else
                        {
                            y += 26;
                        }
                        Application.OpenForms[0].Controls.Add(choice);
                    }
                }
                catch { }
            }
            this.Close();
        }

    }
}
