using CircPOOWindowsForm.Entidades;

namespace CircPOOWindowsForm.Datos
{
	public class RepositorioDeRectangulos
	{
		private readonly string _archivo = Environment.CurrentDirectory + "\\Rectangulos.txt";
		private List<Rectangulo> rectangulos;
        public RepositorioDeRectangulos()
        {
            rectangulos= new List<Rectangulo>();
			LeerDatosDelArchivo();
		}

		private void LeerDatosDelArchivo()
		{
			if (File.Exists(_archivo))
			{
				using (var lector = new StreamReader(_archivo))
				{
					while (!lector.EndOfStream)
					{
						var lineaLeida = lector.ReadLine();
						var rectangulo = ConstuirRectangulo(lineaLeida);
						rectangulos.Add(rectangulo);
					}
				}

			}
		}
		public List<Rectangulo> GetLista() => rectangulos;
		private Rectangulo ConstuirRectangulo(string? lineaLeida)
		{
			var campos = lineaLeida.Split('|');
			var baseRectangulo = int.Parse(campos[0]);
			var alturaRectangulo = int.Parse(campos[1]);
			var bordeRectangulo =(Borde) int.Parse(campos[2]);
			var rellenoRectangulo = (Relleno)int.Parse(campos[3]);
			return new Rectangulo
			{
				Base = baseRectangulo,
				Altura = alturaRectangulo,
				Borde = bordeRectangulo,
				Relleno = rellenoRectangulo
			};
		}

		public void Agregar(Rectangulo rectangulo)
		{
			using (var escritor = new StreamWriter(_archivo, true))
			{
				string lineaEscribir = ConstuirLinea(rectangulo);
				escritor.WriteLine(lineaEscribir);
			}
		}

		private string ConstuirLinea(Rectangulo rectangulo)
		{
			return $"{rectangulo.Base}|{rectangulo.Altura}|{rectangulo.Borde.GetHashCode()}|{rectangulo.Relleno.GetHashCode()}";
		}

		public void Borrar(Rectangulo rectangulo) { }

	}
}