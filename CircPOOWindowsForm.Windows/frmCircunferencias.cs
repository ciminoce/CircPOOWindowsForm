using CircPOOWindowsForm.Datos;
using CircPOOWindowsForm.Entidades;

namespace CircPOOWindowsForm.Windows
{
	public partial class frmCircunferencias : Form
	{

		public frmCircunferencias()
		{
			InitializeComponent();
		}
		RepositorioDeRectangulos repositorio = new RepositorioDeRectangulos();
		List<Rectangulo> rectangulosLista;
		private void frmCircunferencias_Load(object sender, EventArgs e)
		{
			rectangulosLista = repositorio.GetLista();
			MostrarDatosEnGrilla();
		}

		private void MostrarDatosEnGrilla()
		{
			dgvDatos.Rows.Clear();
			foreach (var rectangulo in rectangulosLista)
			{
				DataGridViewRow r = ConstruirFila();
				SetearFila(r, rectangulo);
				AgregarFila(r);
			}
		}

		private void AgregarFila(DataGridViewRow r)
		{
			dgvDatos.Rows.Add(r);
		}

		private void SetearFila(DataGridViewRow r, Rectangulo rectangulo)
		{
			r.Cells[colBase.Index].Value = rectangulo.Base;
			r.Cells[colAltura.Index].Value = rectangulo.Altura;
			r.Cells[colBorde.Index].Value = rectangulo.Borde;
			r.Cells[colRelleno.Index].Value = rectangulo.Relleno;
			r.Cells[colSuperficie.Index].Value = rectangulo.GetArea();
			r.Cells[colPerimetro.Index].Value = rectangulo.GetPerimetro();

			r.Tag = rectangulo;
		}

		private DataGridViewRow ConstruirFila()
		{
			var r = new DataGridViewRow();
			r.CreateCells(dgvDatos);
			return r;
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmCircunferenciaAE frm = new frmCircunferenciaAE() { Text = "Nuevo Rectángulo" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) {
				return;
			}
			Rectangulo rectangulo = frm.GetRectangulo();
			repositorio.Agregar(rectangulo);
			var r=ConstruirFila();
			SetearFila(r, rectangulo);
			AgregarFila(r);

		}
	}
}