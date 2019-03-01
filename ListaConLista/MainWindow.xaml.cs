using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListaConLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Jotaro", "Kujo"));
            listaPersonas.Add(new Persona("Memazo", "Peludo"));

            foreach (Persona persona in listaPersonas)
            {
                ListBoxItem lst = new ListBoxItem();
                lst.Content = persona;
                lstPersonas.Items.Add(lst);
            }
        }

        private void lstPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lst = (ListBoxItem)lstPersonas.SelectedItem;
            Persona persona = (Persona)lst.Content;
            lblNombre.Content = persona.Nombre;
            lblApellido.Content = persona.Apellido;
        }
    }
}
