using System;//Se utiliza la librería system en el proyecto, la cual es necesaria para la creación de ciertas estructuras
using System.Drawing;//Nos ayuda a obtener métodos para dibujar sobre el form
using System.Media;//Se utiliza para reproducir elementos de audio, en este caso 2 efectos de sonido
using System.Windows.Forms;//Es la clase perteneciente a la distinción del form, necesaria para trabajar un form
namespace PIDETEC//Hace referencia al identificador del proyecto donde se conjunta el proyecto
{//Se abre un espacio que va a contener lo dirigido hacia la referencia con el proyecto
    public partial class MenuOpciones : Form//Hace referencia a una parte de la clase en la cual está contenida de la forma, es decir,
    //que nos permite que esté en múltiples espacios
    {//Se abre un espacio que contendrá el código referido a la forma
        int BurritosTotales = 1; int TacosTotales = 1; //Se crea globalmente una variable de burritos y tacos comprados
        int PozolesTotales = 1; int HamburguesasTotales = 1;//Se crea globalmente una variable de pozoles y hamburguesas compradas
        int TotalBurritos = 0; //Se crea globalmente una variable del precio total de los burritos que se quieren comprar
        int TotalTacos = 0;//Se crea globalmente una variable del precio total de los tacos que se quieren comprar
        int TotalPozoles = 0;//Se crea globalmente una variable del precio total de los pozoles que se quieren comprar
        int TotalHamburguesas = 0;//Se crea globalmente una variable del precio total de las hamburguesas que se quieren comprar
        int TotalProductos = 0;//Se crea globalmente una variable del precio total de todo lo comprado
        FrmAcceder frmAcceder = new FrmAcceder();//Se crea un objeto del menu para uso posterior
        Opciones ComidaOpciones = new Opciones();//Se crea un objeto de otra forma para mostrar posteriormente los platillos
        public MenuOpciones()//Se crea un constructor que tendrá las características de la forma del menú
        {//Se abre el espacio del constructor
            InitializeComponent();//Se cargan las características de la forma
        }//Se cierra el espacio del constructor
        private void btnBurrito_MouseEnter(object sender, EventArgs e)//Se crea un evento cuando el mouse para por el botón de burrito
        {//Se abre el espacio del evento
            Point Distancias = new Point(this.Right, this.Top + ClientSize.Height/4);//Se guarda una distancia para el form que muestra comida
            ComidaOpciones.Location = Distancias;//Se cambia la distancia del form que muestra comida al medio a la derecha del primero
            ComidaOpciones.BackgroundImage = Properties.Resources.Burrito;//Se cambia la imagen del form que muestra comida a un burrito
            ComidaOpciones.Show();//se muestra el form que se tiene para representar la comida
        }//Se cierra el espacio del evento
        private void btnBurrito_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón de burrito
        {//Se abre el espacio del evento
            ComidaOpciones.Hide();//Se oculta el form que muestra la comida
        }//Se cierra el espacio del evento
        private void btnTacos_MouseEnter(object sender, EventArgs e)//Se crea un evento cuando el mouse para por el botón de tacos
        {//Se abre el espacio del evento
            Point Distancias = new Point(this.Right, this.Top + ClientSize.Height / 4);//Se guarda una distancia para el form que muestra comida
            ComidaOpciones.Location = Distancias;//Se cambia la distancia del form que muestra comida al medio a la derecha del primero
            ComidaOpciones.BackgroundImage = Properties.Resources.Tacos;//Se cambia la imagen del form que muestra comida a un taco
            ComidaOpciones.Show();//se muestra el form que se tiene para representar la comida
        }//Se cierra el espacio del evento
        private void btnTacos_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón de tacos
        {//Se abre el espacio del evento
            ComidaOpciones.Hide();//Se oculta el form que muestra la comida
        }//Se cierra el espacio del evento
        private void btnHamburguesa_MouseEnter(object sender, EventArgs e)//Se crea un evento cuando el mouse para por el botón de hamburguesas
        {//Se abre el espacio del evento
            Point Distancias = new Point(this.Right, this.Top + ClientSize.Height / 4);//Se guarda una distancia para el form que muestra comida
            ComidaOpciones.Location = Distancias;//Se cambia la distancia del form que muestra comida al medio a la derecha del primero
            ComidaOpciones.BackgroundImage = Properties.Resources.Hamburguesa;//Se cambia la imagen del form que muestra comida a una hamburguesa
            ComidaOpciones.Show();//se muestra el form que se tiene para representar la comida
        }//Se cierra el espacio del evento
        private void btnHamburguesa_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón de hamburguesas
        {//Se abre el espacio del evento
            ComidaOpciones.Hide();//Se oculta el form que muestra la comida
        }//Se cierra el espacio del evento
        private void btnPozole_MouseEnter(object sender, EventArgs e)//Se crea un evento cuando el mouse para por el botón de pozole
        {//Se abre el espacio del evento
            Point Distancias = new Point(this.Right, this.Top + ClientSize.Height / 4);//Se guarda una distancia para el form que muestra comida
            ComidaOpciones.Location = Distancias;//Se cambia la distancia del form que muestra comida al medio a la derecha del primero
            ComidaOpciones.BackgroundImage = Properties.Resources.Pozole;//Se cambia la imagen del form que muestra comida a un pozole
            ComidaOpciones.Show();//se muestra el form que se tiene para representar la comida
        }//Se cierra el espacio del evento
        private void btnPozole_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón de pozole
        {//Se abre el espacio del evento
            ComidaOpciones.Hide();//Se oculta el form que muestra la comida
        }//Se cierra el espacio del evento
        private void btnBurrito_Click(object sender, EventArgs e)//Se crea un evento al presionar sobre el botón del burrito
        {//Se abre el espacio del evento
            if (progressBarBurritos.Value == progressBarBurritos.Maximum)//Se crea una condición si se llena el valor de la barra de 
              //burritos de máximo con el valor de los comprados
            {//se abre el espacio de la condición
                MessageBox.Show("¡Ya no puedes agregar más burritos!");//Indica al usuario que ya no se pueden pedir mas
                //comida de ese tipo, pues se ha agotado
                return;//Se regresa al menú de la comida
            }//se cierra el espacio de la condición
            TotalBurritos = progressBarBurritos.Value += 10;//Se aumenta un valor de 10 pesos al total de los burritos
            TotalProductos = TotalBurritos + TotalTacos + TotalHamburguesas + TotalPozoles;//Se suman los totales nuevos en uno solo
            lblTotalGastado.Text = TotalProductos.ToString();//Se muestra el total gastado en toda la comida seleccionada
            btnBurrito.Text = "Burritos: " + BurritosTotales.ToString();//Se agrega un mensaje con el total de burritos comprados
            BurritosTotales++;//se añada un burrito al total que se tienen comprados
        }//Se cierra el espacio del evento
        private void btnTacos_Click(object sender, EventArgs e)//Se crea un evento al presionar sobre el botón del taco
        {//Se abre el espacio del evento
            if (progressBarTacos.Value == progressBarTacos.Maximum)//Se crea una condición si se llena el valor de la barra de 
            //tacos de máximo con el valor de los comprados
            {//se abre el espacio de la condición
                MessageBox.Show("¡Ya no puedes agregar más Tacos!");//Indica al usuario que ya no se pueden pedir mas
                //comida de ese tipo, pues se ha agotado
                return;//Se regresa al menú de la comida
            }//se cierra el espacio de la condición
            TotalTacos = progressBarTacos.Value += 8;//Se aumenta un valor de 8 pesos al total de los tacos
            TotalProductos = TotalBurritos + TotalTacos + TotalHamburguesas + TotalPozoles;//Se suman los totales nuevos en uno solo
            lblTotalGastado.Text = TotalProductos.ToString();//Se muestra el total gastado en toda la comida seleccionada
            btnTacos.Text = "Tacos: " + TacosTotales.ToString();//Se agrega un mensaje con el total de tacos comprados
            TacosTotales++;//Se añade un taco al total que se tienen comprados
        }//Se cierra el espacio del evento
        private void btnHamburguesa_Click(object sender, EventArgs e)//Se crea un evento al presionar sobre el botón de la hamburguesa
        {//Se abre el espacio del evento
            if (progressBarHamburguesa.Value == progressBarHamburguesa.Maximum)//Se crea una condición si se llena el valor de la barra de 
             //hamburguesa de máximo con el valor de los comprados
            {//Se abre el espacio de la condición
                MessageBox.Show("¡Ya no puedes agregar más Hamburguesas!");//Indica al usuario que ya no se pueden pedir mas
                //comida de ese tipo, pues se ha agotado
                return;//Se regresa al menú de la comida
            }//se cierra el espacio de la condición
            TotalHamburguesas = progressBarHamburguesa.Value += 30;//Se aumenta un valor de 30 pesos al total de las hamburguesas
            TotalProductos = TotalBurritos + TotalTacos + TotalHamburguesas + TotalPozoles;//Se suman los totales nuevos en uno solo
            lblTotalGastado.Text = TotalProductos.ToString();//Se muestra el total gastado en toda la comida seleccionada
            btnHamburguesa.Text = "Hamburguesas: " + HamburguesasTotales.ToString();//Se agrega un mensaje con el total de hamburguesas comprados
            HamburguesasTotales++;//se añade una hamburguesa al total que se tienen comprados
        }//Se cierra el espacio del evento
        private void btnPozole_Click(object sender, EventArgs e)//Se crea un evento al presionar sobre el botón del pozole
        {//Se abre el espacio del evento
            if (progressBarPozole.Value == progressBarPozole.Maximum)//Se crea una condición si se llena el valor de la barra de 
            //pozole de máximo con el valor de los comprados
            {//se abre el espacio de la condición
                MessageBox.Show("¡Ya no puedes agregar más Pozole!");//Indica al usuario que ya no se pueden pedir mas
                //comida de ese tipo, pues se ha agotado
                return;//Se regresa al menú de la comida
            }//Se cierra el espacio de la condición
            TotalPozoles = progressBarPozole.Value += 45;//Se aumenta un valor de 45 pesos al total de el pozole
            TotalProductos = TotalBurritos + TotalTacos + TotalHamburguesas + TotalPozoles;//Se suman los totales nuevos en uno solo
            lblTotalGastado.Text = TotalProductos.ToString();//Se muestra el total gastado en toda la comida seleccionada
            btnPozole.Text = "Pozoles: " + PozolesTotales.ToString();//Se agrega un mensaje con el total de pozoles comprados
            PozolesTotales++;//Se añade un pozole al total que se tienen comprados
        }//Se cierra el espacio del evento
        private void MenuOpciones_Load(object sender, EventArgs e)//Se crea un evento que se activa al cargarse el menú de alimentos
        {//Se abre el espacio del evento
            tlspUsuarioConectadoAhora.Text = "Usuario Conectado: " + FrmAcceder.UsuarioIngresado.ToString();//Se añade el usuario que ha ingresado
            SoundPlayer ReproductorSonido = new SoundPlayer(Properties.Resources.Robot);//Se crea un reproductor para ejecutar un archivo de audio
            ReproductorSonido.Play();//Se reproduce el archivo de audio
        }//Se cierra el espacio del evento
        private void tlspCerrarSesion_Click(object sender, EventArgs e)//Se crea un evento cuando se cierra sesión
        {//Se abre el espacio del evento
            string EleccionCerrar = string.Format("¿En verdad quieres cerrar sesión {0}", FrmAcceder.UsuarioIngresado.ToString());//Se guarda
            //un texto con formato preguntando al usuario si quiere cerrar su sesión
            DialogResult EleccionDefinida = MessageBox.Show(EleccionCerrar, "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//Se
            //muestra el texto previamente guardado con las opciones de presionar si o no
            if (EleccionDefinida == DialogResult.Yes)//Se cumple una condición cuando se presiona si
            {//Se abre el espacio de ejecución de la condición
                SoundPlayer ReproductorSonido = new SoundPlayer(Properties.Resources.DarthVader);//Se crea un reproductor y se ejecuta un archivo de audio
                ReproductorSonido.Play();//Se reproduce el archivo de audio
                this.Hide();//Se oculta la forma del menú
                frmAcceder.ShowDialog();//Se muestra nuevamente la forma del acceso para ingresar con otro o el mismo usuario
            }//Se cierra el espacio de ejecución de la condición
            if (EleccionDefinida == DialogResult.No)//Se cumple una condición cuando se presiona no
            {//Se abre el espacio de ejecución de la condición
                return;//Se retorna al menú
            }//Se cierra el espacio de ejecución de la condición
        }//Se cierra el espacio del evento

        private void tlspUsuarioConectadoAhora_Click(object sender, EventArgs e)
        {

        }
    }//Se cierra un espacio que contendrá el código referido a la forma
}//Se cierra un espacio que va a contener lo dirigido hacia la referencia con el proyecto