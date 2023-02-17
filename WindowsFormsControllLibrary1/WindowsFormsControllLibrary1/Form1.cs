namespace WindowsFormsControllLibrary1
{
    public partial class Form1 : Form
    {
        Matricula matricula = new Matricula();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Estudiante estudiante = new Estudiante(txtCif.Text, txtNombres.Text, txtApellidos.Text,
                dtpFechaNac.Value, cbFacultad.Text, cbCarrera.Text);


            if (matricula.agregarISI(estudiante))
            {
                MessageBox.Show("Estudiante Guardado");
                LlenarDataGrid();
            }
            else
            {
                MessageBox.Show("No se agrego el estudiante");
            }
                
        
            
            limpiar();

        }

        private bool validarSistemas(Estudiante est)
        {
            if(est.Carrera == "Sistemas")
            {
                return true;
            }
            return false;
        }

        private void estudiantesSistemas()
        {

        }

        private void LlenarDataGrid() { 
        
            dgvRegistros.DataSource= matricula.listado.ToArray();
            dgvRegistros.Refresh();
        }

        private void limpiar() {
            txtCif.Text = "";
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNac.Value = DateTime.Now;
            cbCarrera.SelectedIndex= -1;
            cbFacultad.SelectedIndex = -1;
            txtCif.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}