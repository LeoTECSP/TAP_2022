using System;//Se utiliza la librería system en el proyecto, la cual es necesaria para la creación de ciertas estructuras
using System.Windows.Forms;//Es la clase perteneciente a la distinción del form, necesaria para trabajar un form
namespace PIDETEC//Hace referencia al identificador del proyecto donde se conjunta el proyecto
{//Se abre un espacio que va a contener lo dirigido hacia la referencia al conjunto del proyecto
    static class Program//Se crea una clase program que se ejecutará en un principio
    {//Se abre el espacio de la clase
        [STAThread] //Se tiene un punto de entrada de la ejecución del programa
        static void Main()//Se crea el método principal donde se ejecutará la forma escogida previamente
        {//Se abre el espacio del método
            Application.EnableVisualStyles();//Se activan los estilos visuales para ver gráficos, texto, colores, entre otras cosas
            Application.SetCompatibleTextRenderingDefault(false);//Se niega la compatibilidad de ciertos controles de la forma
            Application.Run(new FrmAcceder());//Se ejecuta la forma que muestra el acceso a ingresar nuestra información
        }//Se cierra el espacio del método
    }//Se cierra el espacio de la clase
}//Se cierra un espacio que va a contener lo dirigido hacia la referencia con el conjunto del proyecto