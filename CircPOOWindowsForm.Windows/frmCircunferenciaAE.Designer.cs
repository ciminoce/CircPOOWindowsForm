namespace CircPOOWindowsForm.Windows
{
	partial class frmCircunferenciaAE
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new Label();
			txtBase = new TextBox();
			label2 = new Label();
			txtAltura = new TextBox();
			cboColores = new ComboBox();
			label3 = new Label();
			gbxBordes = new GroupBox();
			btnCancelar = new Button();
			btnOK = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 55);
			label1.Name = "label1";
			label1.Size = new Size(34, 15);
			label1.TabIndex = 0;
			label1.Text = "Base:";
			// 
			// txtBase
			// 
			txtBase.Location = new Point(144, 52);
			txtBase.Name = "txtBase";
			txtBase.Size = new Size(100, 23);
			txtBase.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(39, 84);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 0;
			label2.Text = "Altura:";
			// 
			// txtAltura
			// 
			txtAltura.Location = new Point(144, 81);
			txtAltura.Name = "txtAltura";
			txtAltura.Size = new Size(100, 23);
			txtAltura.TabIndex = 1;
			// 
			// cboColores
			// 
			cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
			cboColores.FormattingEnabled = true;
			cboColores.Location = new Point(144, 110);
			cboColores.Name = "cboColores";
			cboColores.Size = new Size(153, 23);
			cboColores.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(39, 112);
			label3.Name = "label3";
			label3.Size = new Size(81, 15);
			label3.TabIndex = 4;
			label3.Text = "Color Relleno:";
			// 
			// gbxBordes
			// 
			gbxBordes.Location = new Point(39, 155);
			gbxBordes.Name = "gbxBordes";
			gbxBordes.Size = new Size(258, 108);
			gbxBordes.TabIndex = 6;
			gbxBordes.TabStop = false;
			gbxBordes.Text = " Tipos de Bordes ";
			// 
			// btnCancelar
			// 
			btnCancelar.Image = Properties.Resources.cancel_24px;
			btnCancelar.Location = new Point(265, 289);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(95, 56);
			btnCancelar.TabIndex = 7;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnOK
			// 
			btnOK.Image = Properties.Resources.ok_24px;
			btnOK.Location = new Point(12, 289);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(95, 56);
			btnOK.TabIndex = 8;
			btnOK.Text = "OK";
			btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmCircunferenciaAE
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(372, 364);
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(gbxBordes);
			Controls.Add(cboColores);
			Controls.Add(label3);
			Controls.Add(txtAltura);
			Controls.Add(label2);
			Controls.Add(txtBase);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "frmCircunferenciaAE";
			Text = "frmCircunferenciaAE";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtBase;
		private Label label2;
		private TextBox txtAltura;
		private ComboBox cboColores;
		private Label label3;
		private GroupBox gbxBordes;
		private Button btnCancelar;
		private Button btnOK;
		private ErrorProvider errorProvider1;
	}
}