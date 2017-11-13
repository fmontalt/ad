using System;
using System.Data;

using Serpis.Ad;

namespace CArticulo
{
    public partial class ArticuloWindow : Gtk.Window
    {
        public ArticuloWindow(Articulo articulo) : base(Gtk.WindowType.Toplevel) {
            this.Build();
            entryNombre.Text = articulo.Nombre;
            //spinbuttonPrecio. = articulo.Precio;
            //entryCategoria. = articulo.Categoria;

			saveAction.Activated += delegate {
                articulo.Nombre = entryNombre.Text;
				//CategoriaDao.Save(categoria);
				Destroy();
			};
        }

	
    }
}
