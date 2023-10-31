using CircPOOWindowsForm.Entidades;

namespace CircPOOWindowsForm.Windows
{
	public partial class frmCircunferenciaAE : Form
	{
		public frmCircunferenciaAE()
		{
			InitializeComponent();
		}
		List<Borde> listaBordes = Enum.GetValues(typeof(Borde))
				.Cast<Borde>().ToList();
		private Rectangulo rectangulo;
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CargarComboColores();
			CrearRadioButtonsBordes();
		}

		private void CrearRadioButtonsBordes()
		{
			int x = 13;
			int y = 19;
			bool check = true;
			foreach (var itemBorde in listaBordes)
			{
				RadioButton rb = new RadioButton
				{
					Name = $"rbt{itemBorde.ToString()}",
					Text = itemBorde.ToString(),
					Location = new Point(x, y),
					Checked = check
				};
				gbxBordes.Controls.Add(rb);
				y += 20;
				check = false;
			}
		}

		private void CargarComboColores()
		{
			var listaColores = Enum.GetValues(typeof(Relleno))
				.Cast<Relleno>().ToList();
			cboColores.DataSource = listaColores;
			cboColores.SelectedIndex = 0;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				rectangulo = new Rectangulo();
				rectangulo.Base = int.Parse(txtBase.Text);
				rectangulo.Altura = int.Parse(txtAltura.Text);
				rectangulo.Relleno =(Relleno) cboColores.SelectedItem;
				rectangulo.Borde = ObtenerBorde();

				DialogResult = DialogResult.OK;
			}

		}

		private Borde ObtenerBorde()
		{
			Borde tipo = 0;
			foreach (var itemBorde in listaBordes)
			{
				var key = $"rbt{itemBorde.ToString()}";
				var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
				if (rb.Checked)
				{
					tipo = itemBorde;
					break;
				}
			}
			return tipo;
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();
			if (!int.TryParse(txtBase.Text,out int baseRect))
			{
				valido = false;
				errorProvider1.SetError(txtBase, "Base no numérica!!!");
			}else if (baseRect <= 0)
			{
				valido = false;
				errorProvider1.SetError(txtBase, "Base no válida!!!");
			}
			if (!int.TryParse(txtAltura.Text, out int alturaRect))
			{
				valido = false;
				errorProvider1.SetError(txtBase, "Altura no numérica!!!");
			}
			else if (alturaRect <= 0)
			{
				valido = false;
				errorProvider1.SetError(txtAltura, "Altura no válida!!!");
			}
			if (alturaRect==baseRect)
			{
				valido = false;
				errorProvider1.SetError(txtAltura, "Base y altura son iguales!!!!");
			}
			return valido;
		}

		public Rectangulo GetRectangulo()
		{
			return rectangulo;
		}
	}
}
