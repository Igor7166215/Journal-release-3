using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Журнал
{
    public partial class Добавить_оценку : Form
    {
        public static string connectionstring = Properties.Settings.Default.ЖурналConnectionString;
        public string SqlStr = "";
        private string Sql = "";
        public OleDbConnection connection = new OleDbConnection(connectionstring);

        public Добавить_оценку()
        {
            
            InitializeComponent();
            //комбо ученик
            DataTable Workerstable = new DataTable();
            var oleCommand = new OleDbCommand("SELECT [Код], STR([Код]) + \".\" + Фамилия + \" \" + Имя + \" \" + Отчество AS Ученик FROM Ученики", connection);
            var adapter = new OleDbDataAdapter(oleCommand);

            Workerstable.Clear();
            adapter.Fill(Workerstable);
            kod.ValueMember = "Код ученика";
            kod.DisplayMember = "Ученик";
            kod.DataSource = Workerstable;

            //комбо дисциплина
            DataTable Workerstable1 = new DataTable();
            var oleCommand1 = new OleDbCommand("SELECT [Код], STR([Код]) + \".\" + Название AS Дисциплина FROM Дисциплины", connection);
            var adapter1 = new OleDbDataAdapter(oleCommand1);

            Workerstable1.Clear();
            adapter1.Fill(Workerstable1);
            discip.ValueMember = "Код дисциплины";
            discip.DisplayMember = "Дисциплина";
            discip.DataSource = Workerstable1;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(Form1.connectionstring);
            string Sql = "";
            connection.Open();
            try
            {
                Form1 main = new Form1();
                string[] Kod_id = kod.Text.Split(new char[] { '.' });
                string[] Kod_discip = discip.Text.Split(new char[] { '.' });
                Sql =
                    "INSERT INTO Оценки ([Код дисциплины], [Код ученика], [Оценки] " +
                    ") Values ('"
                                       + Kod_discip[0] + "' , '"
                                       + Kod_id[0] + "' , '"
                                       + grade.Text + " " + "') ";

                OleDbCommand Cmd = new OleDbCommand(Sql, connection);
                Cmd.ExecuteNonQuery();
                connection.Close();
                GC.Collect();
            }
            finally
            {
            }
            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
