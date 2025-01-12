using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace GestionAlquileresDesportivos.Vistas
{
    public partial class Program : Form
    {
        public Program()
        {
            InitializeComponent();
        }

        private void Program_Load(object sender, EventArgs e)
        {

        }
    }
}

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormPrincipal());
    }
}