using Artemisapp_BE;
using Artemisapp_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemisapp_UX
{
    public partial class ProductoAlmacen : Form
    {
        ProductoBLL bll = new ProductoBLL();

        public ProductoAlmacen()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto(
                    txtId.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCategoria.Text,
                    dtpVencimiento.Value,
                    double.Parse(txtPrecio.Text, CultureInfo.InvariantCulture),
                    txtProveedor.Text,
                    int.Parse(txtStock.Text)
                );

                bool resultado = bll.RegistrarProducto(p);

                if (resultado)
                    lblResultado.Text = "Producto guardado correctamente.";
                else
                    lblResultado.Text = "No se pudo guardar.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int stockRestante = bll.DescontarUnidad(txtId.Text);

                if (stockRestante == -1)
                {
                    lblResultado.Text = "No se encontró ningún producto con ese ID.";
                    return;
                }

                CargarGrilla();

                if (stockRestante == 0)
                {
                    MessageBox.Show("No hay más unidades del producto.",
                                    "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblResultado.Text = "Producto sin unidades disponibles.";
                }
                else if (stockRestante <= 3)
                {
                    MessageBox.Show("Pocas existencias del producto. Quedan " + stockRestante + " unidades.",
                                    "Stock bajo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultado.Text = "Se descontó 1 unidad. Stock: " + stockRestante;
                }
                else
                {
                    lblResultado.Text = "Se descontó 1 unidad. Stock: " + stockRestante;
                }

                // Refrescar el campo stock en pantalla en vez de limpiar todo
                txtStock.Text = stockRestante.ToString();
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = bll.BuscarProductoPorId(txtId.Text);

                if (p != null)
                {
                    txtNombre.Text = p.Nombre;
                    txtDescripcion.Text = p.Descripcion;
                    txtCategoria.Text = p.Categoria;
                    dtpVencimiento.Value = p.FechaDeVencimiento;
                    txtPrecio.Text = p.Precio.ToString(CultureInfo.InvariantCulture);
                    txtProveedor.Text = p.Proveedor;
                    txtStock.Text = p.Stock.ToString();
                    lblResultado.Text = "✅ Encontrado: " + p.Nombre +
                    " \n| Descripción: " + p.Descripcion +
                    " \n| Categoría: " + p.Categoria +
                    " \n| Vencimiento: " + p.FechaDeVencimiento.ToString("dd/MM/yyyy") +
                    " \n| Precio: $" + p.Precio.ToString(CultureInfo.InvariantCulture) +
                    " \n| Proveedor: " + p.Proveedor +
                    " \n| Stock: " + p.Stock;
                }
                else
                {
                    lblResultado.Text = "No se encontró ningún producto con ese ID.";
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e) // limpiar campos
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtProveedor.Clear();
            txtStock.Clear();
            lblDescripcion.Text = "Descripción";
            lblResultado.Text = "Resultado";

            //para dejar el cursor en foco en el campo de nombre
            txtNombre.Focus();
        }

        // LOAD de producto almacen, carga la grilla y verifica los productos próximos a vencerse
        private void ProductoAlmacen_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            VerificarVencimientos();           
        }

        private void CargarGrilla()
        {
            dtgvProductoAlmacen.DataSource = null;              // desengancha la lista vieja
            dtgvProductoAlmacen.DataSource = bll.ObtenerTodos()
                                        .OrderBy(p => p.Nombre)
                                        .ToList();
        }

        private void FiltrarGrillaPorNombre(string texto)
        {
            List<Producto> filtrados = bll.ObtenerTodos()
                .Where(p => p.Nombre != null &&
                            p.Nombre.ToLower().Contains(texto.ToLower()))
                .OrderBy(p => p.Nombre)
                .ToList();

            dtgvProductoAlmacen.DataSource = null;
            dtgvProductoAlmacen.DataSource = filtrados;
        }

        private void VerificarVencimientos()
        {
            List<Producto> proximos = bll.ObtenerProximosAVencer();

            foreach (Producto p in proximos)
            {
                MessageBox.Show(
                    "Producto próximo a vencerse: " + p.Nombre +
                    "\nFecha de vencimiento: " + p.FechaDeVencimiento.ToString("dd/MM/yyyy"),
                    "Aviso de vencimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void dtgvProductoAlmacen_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvProductoAlmacen.CurrentRow != null &&
                dtgvProductoAlmacen.CurrentRow.DataBoundItem is Producto p)
            {
                lblProdDescripcion.Text = p.Nombre;
                lblDescripcion.Text = p.Descripcion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                if (!int.TryParse(txtStock.Text, out cantidad) || cantidad <= 0)
                {
                    lblResultado.Text = "Ingresá una cantidad válida (mayor a 0).";
                    return;
                }

                int stockResultante = bll.AgregarStock(txtId.Text, cantidad);

                if (stockResultante == -1)
                {
                    lblResultado.Text = "No se encontró ningún producto con ese ID.";
                    return;
                }

                CargarGrilla();
                lblResultado.Text = "Stock actualizado. Ahora hay " + stockResultante + " unidades.";
                txtStock.Text = stockResultante.ToString();
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. El producto tiene que existir (se busca por el ID, que no se modifica)
                Producto existente = bll.BuscarProductoPorId(txtId.Text);

                if (existente == null)
                {
                    MessageBox.Show("No se encontró ningún producto con ese ID.",
                                    "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validaciones de los campos editados
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.",
                                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double precio;
                if (!double.TryParse(txtPrecio.Text, out precio) || precio < 0)
                {
                    MessageBox.Show("Ingresá un precio válido.",
                                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stock;
                if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
                {
                    MessageBox.Show("Ingresá un stock válido (0 o más).",
                                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Armamos el producto con lo que quedó en los textbox
                Producto modificado = new Producto(
                    txtId.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtCategoria.Text,
                    dtpVencimiento.Value,
                    precio,
                    txtProveedor.Text,
                    stock
                );

                // 4. Actualizar, refrescar la grilla y avisar
                if (bll.ActualizarProducto(modificado))
                {
                    CargarGrilla();
                    MessageBox.Show("Datos modificados con éxito.",
                                    "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultado.Text = "Producto modificado correctamente.";
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.",
                                    "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }


        private void dtgvProductoAlmacen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvProductoAlmacen.Rows[e.RowIndex].DataBoundItem is Producto p)
            {
                if (p.Stock == 0)
                {
                    // Sin stock → fila roja
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (p.Stock <= 3)
                {
                    // Pocas existencias → fila amarilla
                    e.CellStyle.BackColor = Color.Khaki;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }


        // Botón de búsqueda por nombre, que filtra la grilla según el texto ingresado
        private void btnBusquedaPorNombre_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBusquedaPorNombre.Text.Trim();

                if (string.IsNullOrEmpty(texto))
                {
                    // Sin texto → mostrar todo de nuevo
                    CargarGrilla();
                    lblResultado.Text = "Mostrando todos los productos.";
                    return;
                }

                FiltrarGrillaPorNombre(texto);

                if (dtgvProductoAlmacen.Rows.Count == 0)
                    lblResultado.Text = "No se encontraron productos con ese nombre.";
                else
                    lblResultado.Text = "Se encontraron " + dtgvProductoAlmacen.Rows.Count + " producto(s).";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error: " + ex.Message;
            }
        }


        // suscripcion del evento del textbox de busqueda por nombre
        // para que filtre en tiempo real mientras se escribe
        private void txtBusquedaPorNombre_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBusquedaPorNombre.Text.Trim();

            if (string.IsNullOrEmpty(texto))
                CargarGrilla();
            else
                FiltrarGrillaPorNombre(texto);
        }
    }   
}
