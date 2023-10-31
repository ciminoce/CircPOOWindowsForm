namespace CircPOOWindowsForm.Windows
{
	partial class frmCircunferencias
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			tsbBorrar = new ToolStripButton();
			tsbEditar = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsbFiltrar = new ToolStripButton();
			tsbActualizar = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			tsbOrdenar = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			tsbSalir = new ToolStripButton();
			panel1 = new Panel();
			panel2 = new Panel();
			dgvDatos = new DataGridView();
			colBase = new DataGridViewTextBoxColumn();
			colAltura = new DataGridViewTextBoxColumn();
			colBorde = new DataGridViewTextBoxColumn();
			colRelleno = new DataGridViewTextBoxColumn();
			colPerimetro = new DataGridViewTextBoxColumn();
			colSuperficie = new DataGridViewTextBoxColumn();
			toolStrip1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1026, 54);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.new_copy_32px;
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(46, 51);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// tsbBorrar
			// 
			tsbBorrar.Image = Properties.Resources.delete_file_32px;
			tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbBorrar.ImageTransparentColor = Color.Magenta;
			tsbBorrar.Name = "tsbBorrar";
			tsbBorrar.Size = new Size(43, 51);
			tsbBorrar.Text = "Borrar";
			tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbEditar
			// 
			tsbEditar.Image = Properties.Resources.edit_file_32px;
			tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
			tsbEditar.ImageTransparentColor = Color.Magenta;
			tsbEditar.Name = "tsbEditar";
			tsbEditar.Size = new Size(41, 51);
			tsbEditar.Text = "Editar";
			tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 54);
			// 
			// tsbFiltrar
			// 
			tsbFiltrar.Image = Properties.Resources.filled_filter_32px;
			tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbFiltrar.ImageTransparentColor = Color.Magenta;
			tsbFiltrar.Name = "tsbFiltrar";
			tsbFiltrar.Size = new Size(41, 51);
			tsbFiltrar.Text = "Filtrar";
			tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = Properties.Resources.refresh_32px;
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(63, 51);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 54);
			// 
			// tsbOrdenar
			// 
			tsbOrdenar.Image = Properties.Resources.sorting_arrows_32px;
			tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
			tsbOrdenar.ImageTransparentColor = Color.Magenta;
			tsbOrdenar.Name = "tsbOrdenar";
			tsbOrdenar.Size = new Size(54, 51);
			tsbOrdenar.Text = "Ordenar";
			tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 54);
			// 
			// tsbSalir
			// 
			tsbSalir.Image = Properties.Resources.exit_32px;
			tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
			tsbSalir.ImageTransparentColor = Color.Magenta;
			tsbSalir.Name = "tsbSalir";
			tsbSalir.Size = new Size(36, 51);
			tsbSalir.Text = "Salir";
			tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// panel1
			// 
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 546);
			panel1.Name = "panel1";
			panel1.Size = new Size(1026, 51);
			panel1.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.Controls.Add(dgvDatos);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 54);
			panel2.Name = "panel2";
			panel2.Size = new Size(1026, 492);
			panel2.TabIndex = 2;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colBase, colAltura, colBorde, colRelleno, colPerimetro, colSuperficie });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowTemplate.Height = 25;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1026, 492);
			dgvDatos.TabIndex = 0;
			// 
			// colBase
			// 
			colBase.HeaderText = "Base";
			colBase.Name = "colBase";
			colBase.ReadOnly = true;
			// 
			// colAltura
			// 
			colAltura.HeaderText = "Altura";
			colAltura.Name = "colAltura";
			colAltura.ReadOnly = true;
			// 
			// colBorde
			// 
			colBorde.HeaderText = "Borde";
			colBorde.Name = "colBorde";
			colBorde.ReadOnly = true;
			// 
			// colRelleno
			// 
			colRelleno.HeaderText = "Relleno";
			colRelleno.Name = "colRelleno";
			colRelleno.ReadOnly = true;
			// 
			// colPerimetro
			// 
			colPerimetro.HeaderText = "Perímetro";
			colPerimetro.Name = "colPerimetro";
			colPerimetro.ReadOnly = true;
			// 
			// colSuperficie
			// 
			colSuperficie.HeaderText = "Superficie";
			colSuperficie.Name = "colSuperficie";
			colSuperficie.ReadOnly = true;
			// 
			// frmCircunferencias
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1026, 597);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(toolStrip1);
			Name = "frmCircunferencias";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Rectángulos";
			Load += frmCircunferencias_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton tsbNuevo;
		private ToolStripButton tsbBorrar;
		private ToolStripButton tsbEditar;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton tsbFiltrar;
		private ToolStripButton tsbActualizar;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton tsbOrdenar;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton tsbSalir;
		private Panel panel1;
		private Panel panel2;
		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colBase;
		private DataGridViewTextBoxColumn colAltura;
		private DataGridViewTextBoxColumn colBorde;
		private DataGridViewTextBoxColumn colRelleno;
		private DataGridViewTextBoxColumn colPerimetro;
		private DataGridViewTextBoxColumn colSuperficie;
	}
}