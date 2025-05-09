using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Login : Form
    {
        private DataBaseHandler Database;

        public Form_Login(DataBaseHandler database)
        {
            Database = database;
            InitializeComponent();
        }

    }
}
