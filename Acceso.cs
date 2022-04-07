/*
 NOMBRE DE PRÁCTICA: PIDETEC
 TEMA DE REFERENCIA: INTERFAZ GRÁFICA DE USUARIO
 OBJETIVO DE LA PRÁCTICA:DESARROLLAR E IMPLEMENTAR UNA APLICACIÓN PARA WINDOWS FORMS,
 HACIENDO USO DEL LENGUAJE DE PROGRAMACIÓN C# Y EL IDE VISUAL STUDIO
 COMMUNITY EDITION (2015+), QUE PERMITA TOMAR ORDENES DE COMIDA EN
 LA CAFETERÍA DE UNA INSTITUCIÓN EDUCATIVA. 
 MATERIA: TÓPICOS AVANZADOS DE PROGRAMACIÓN
 ALUMNO:LEONARDO LOZA MILÁN
 */
using System;//Se utiliza la librería system en el proyecto, la cual es necesaria para la creación de ciertas estructuras
using System.Collections.Generic;//Contiene interfaces y clases para definir colecciones, en este caso un diccionario
using System.Drawing;//Nos ayuda a obtener métodos para dibujar sobre el form
using System.Windows.Forms;//Es la clase perteneciente a la distinción del form, necesaria para trabajar un form
namespace PIDETEC//Hace referencia al identificador del proyecto donde se conjunta el proyecto
{//Se abre un espacio que va a contener lo dirigido hacia la referencia con el proyecto
    public partial class FrmAcceder : Form//Hace referencia a una parte de la clase en la cual está contenida de la forma, es decir,
    //que nos permite que esté en múltiples espacios
    {//Se abre un espacio que contendrá el código referido a la forma
        Dictionary<string, string> Alumnos = new Dictionary<string, string>();//Se crea una biblioteca que guardará datos del alumno
        Dictionary<string, string> Empleados = new Dictionary<string, string>();//Se crea una biblioteca que guardará datos del empleado
        public static string UsuarioIngresado;//Se crea una variable global estática que almacenará el nombre del usuario
        Form AccederMenuComida;//Se crea una instancia para poder utilizar el 2do form
        public FrmAcceder()//Se refiere al metodo constructor para inicializar los componentes de la forma creada
        {//Se abre el espacio de código dirigido a la inicialización
            InitializeComponent();//Se ejecuta el método donde se localiza la información relacionada a la inicialización del contenido de la forma
            Alumnos.Add("201000079", "ALVAREZ LOZA JOB ALBERTO");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000180", "AVITIA MUÑIZ ELIENAI AZUCENA");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000068", "CENICEROS CABRERA YOHEL");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000078", "HERNANDEZ AGUILAR NAYDELIN GUADALUPE");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000130", "JIMENEZ IBARRA HECTOR ADAIR");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000133", "LOZA MILAN LEONARDO");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");//Se añade al diccionario la matrícula y nombre de un alumno
            Alumnos.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");//Se añade al diccionario la matrícula y nombre de un alumno
            Empleados.Add("1138", "MTI. Ulises Martínez Rodríguez");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1367", "ME. Idalia Ruiz Arroyo");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1023", "Ing. Américo Martínez Ovalle");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1115", "Ing. Oscar Fabian Ramos Ochoa");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1011", "MEBC. Alejandro Hernández López");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1012", "MEBC. Cinthia Valeria Jordan Lara");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1111", "MC. Jose Martín Mendoza Rodríguez");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1234", "MC. Elsa Carolina Ávila Salomón");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1559", "MODC. Faustino Esquivel Domínguez");//Se añade al diccionario el número de empleado y nombre de un empeado
            Empleados.Add("1560", "Ing. Jose Luís Mota Espeleta");//Se añade al diccionario el número de empleado y nombre de un empeado
        }//Se cierra el espacio de código dirigido a la inicialización
        private void btnAceptar_Click(object sender, EventArgs e)//Identifica al evento click del botón aceptar
        {//Se abre el espacio de código dirigido  las acciones realizadas cuando se ejecute el evento
            string MensajeEntrada = string.Empty;//Se asigna un valor a un mensaje de entrada recién creado
            if (Alumnos.ContainsKey(txtUsuarioIngreso.Text))//Se realiza una verificación de la existencia de la clave de un alumno con lo ingresado 
            {//Se abre el espacio de la estructura
                MensajeEntrada = string.Format("¡Bienvenido a PIDETEC {0} !, esperamos brindarte la mejor atención :)", Alumnos[txtUsuarioIngreso.Text].ToString());//Se guarda un mensaje de entrada
                //con formato y botones para el usuario al ingresar
                UsuarioIngresado = Alumnos[txtUsuarioIngreso.Text].ToString();//se guarda en una variable el usuario que ha ingresado
                MessageBox.Show(MensajeEntrada, "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Information);//Se muestra el mensaje previamente almacenado
                AccederMenuComida = new MenuOpciones();//Se crea una instancia relacionada al menú de comida
                MenuOpciones menuOpciones = new MenuOpciones();//Se crea un objeto del menú de comida
                menuOpciones.tlspUsuarioConectadoAhora.Text = "Usuario conectado: " + UsuarioIngresado.ToString();//Se manda el nombre de usuario al menu comida
                this.Hide();//Se oculta la forma de acceso 
                DialogResult PresentarForm = AccederMenuComida.ShowDialog();//Se define la forma que tiene el menú de la comida aparezca
                if (PresentarForm == DialogResult.OK)//se crea una estructura si se cumple la condición anterior al presionar el botón
                {//Se abre el espacio de ejecución de la condición
                    this.Show();//Se muestra el form del menú de la comida
                }//Se cierra el espacio de ejecución de la condición
            }//Se cierra el espacio de la estructura
            if (Empleados.ContainsKey(txtUsuarioIngreso.Text))//Se realiza una verificación de la existencia de la clave de un empleado con lo ingresado 
            {//Se abre el espacio de la estructura
                MensajeEntrada = string.Format("¡Bienvenido a PIDETEC {0}!, esperamos brindarte la mejor atención :)", Empleados[txtUsuarioIngreso.Text].ToString());//Se guarda un mensaje de entrada
                //con formato y botones para el usuario al ingresar
                UsuarioIngresado = Empleados[txtUsuarioIngreso.Text].ToString();//se guarda en una variable el usuario que ha ingresado
                MessageBox.Show(MensajeEntrada, "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Information);//Se muestra el mensaje previamente almacenado
                AccederMenuComida = new MenuOpciones();//Se crea una instancia relacionada al menú de comida
                MenuOpciones menuOpciones = new MenuOpciones();//Se crea un objeto del menú de comida
                menuOpciones.tlspUsuarioConectadoAhora.Text = "Usuario conectado: " + UsuarioIngresado.ToString();//Se manda el nombre de usuario al menu comida
                this.Hide();//Se oculta la forma de acceso 
                DialogResult PresentarForm = AccederMenuComida.ShowDialog();//Se define la forma que tiene el menú de la comida aparezca
                if (PresentarForm == DialogResult.OK)//se crea una estructura si se cumple la condición anterior al presionar el botón
                {//Se abre el espacio de ejecución de la condición
                    this.Show();//Se muestra el form del menú de la comida
                }//Se cierra el espacio de ejecución de la condición 
            }//Se cierra el espacio de la estructura
            if (checkBoxInvitado.Checked == true && txtUsuarioIngreso.Text != "Ingresa tu nombre de invitado")//Se realiza verificación especial en caso de ser invitado
            {//Se abre el espacio de la estructura
                MensajeEntrada = string.Format("¡Bienvenido a PIDETEC {0}!, esperamos brindarte la mejor atención :)", txtUsuarioIngreso.Text.ToString());//Se guarda un mensaje de entrada
                //con formato y botones para el usuario al ingresar
                UsuarioIngresado = txtUsuarioIngreso.Text.ToString();//se guarda en una variable el usuario que ha ingresado
                MessageBox.Show(MensajeEntrada, "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Information);//Se muestra el mensaje previamente almacenado
                AccederMenuComida = new MenuOpciones();//Se crea una instancia relacionada al menú de comida
                MenuOpciones menuOpciones = new MenuOpciones();//Se crea un objeto del menú de comida
                menuOpciones.tlspUsuarioConectadoAhora.Text = "Usuario conectado: " + UsuarioIngresado.ToString();//Se manda el nombre de usuario al menu comida
                this.Hide();//Se oculta la forma de acceso 
                DialogResult PresentarForm = AccederMenuComida.ShowDialog();//Se define la forma que tiene el menú de la comida aparezca
                if (PresentarForm == DialogResult.OK)//se crea una estructura si se cumple la condición anterior al presionar el botón
                {//Se abre el espacio de ejecución de la condición
                    this.Show();//Se muestra el form del menú de la comida
                }//Se cierra el espacio de ejecución de la condición 
            }//Se cierra el espacio de ejecución de la estructura principal
            if (Empleados.ContainsKey(txtUsuarioIngreso.Text)==false || Alumnos.ContainsKey(txtUsuarioIngreso.Text) == false)//Se reliza una verificación
                //en caso de no existir un usuario
            {//Se abre el espacio de ejecución de la condición
                MessageBox.Show("No existe este usuario");//Se muestra un mensaje indicando que el usuario no existe
            }//Se cierra el espacio de ejecución de la condición 
        }//Se cierra el bloque del evento
        private void txtUsuarioIngreso_Click(object sender, EventArgs e)//Identifica al evento click a la caja de texto al ingresar
        {//Se abre el espacio del evento
            txtUsuarioIngreso.Text = string.Empty;//Se limpia el texto que se encuentre en la caja de texto
        }//Se cierra el espacio del evento
        private void checkBoxInvitado_Click(object sender, EventArgs e)//Identifica al evento click al presionarse para invitado
        {//Se abre el bloque del evento
            if (checkBoxInvitado.Checked ==true)//Se verifica si se encuentra presionada la caja
            {//Se abre el espacio de ejecución de la condición
                string OpcionInvitado = string.Format("¿Desea entrar como invitado? (Se tendrá que ingresar un nombre)");//Se guarda en una variable
                //un mensaje con formato
                DialogResult OpcionEscogida = MessageBox.Show(OpcionInvitado, "Opciones", MessageBoxButtons.YesNo);//Se muestra el mensaje al usuario 
                if (OpcionEscogida == DialogResult.Yes)//Se abre la condición si se presionó sí
                {//Se abre el espacio de ejecución de la condición
                    txtUsuarioIngreso.Text = string.Empty;//Se limpia el texto que se encuentre en la caja de texto
                    txtUsuarioIngreso.Focus();//Se le da el foco de atención a la caja de texto
                    txtUsuarioIngreso.Text = "Ingresa tu nombre de invitado";//Se pide el nombre del invitado
                }//Se cierra el espacio de ejecución de la condición 
                if (OpcionEscogida == DialogResult.No)//Se abre la condición si se presionó no
                {//Se abre el espacio de ejecución de la condición
                    txtUsuarioIngreso.Text = string.Empty;//Se limpia el texto que se encuentre en la caja de texto
                    txtUsuarioIngreso.Focus();//Se le da el foco de atención a la caja de texto
                    txtUsuarioIngreso.Text = "Ingresa tu matrícula o número de empleado";//Se pide los datos del alumno o empleado
                    checkBoxInvitado.Checked = false;//Se cambia la condición del estado de invitado
                }//Se cierra el espacio de ejecución de la condición 
            }//Se cierra el espacio de ejecución de la condición principal
            if (checkBoxInvitado.Checked == false)//Se abre la condición en caso de que no se encuentre presionada la caja
            {//Se abre el espacio de ejecución de la condición
                checkBoxInvitado.Checked = false;//Se cambia el estado a falso del invitado
                txtUsuarioIngreso.Text = string.Empty;//Se limpia el texto que se encuentre en la caja de texto
                MessageBox.Show("Usted ha salido del modo invitado");//Se menciona que ha salido del invitado
                txtUsuarioIngreso.Text = "Ingresa tu matrícula o número de empleado";//Se reingresa la nota al haber cambiado de modo
            }//Se cierra el espacio de ejecución de la condición principal
        }//Se cierra el espacio del evento
        private void txtUsuarioIngreso_KeyPress(object sender, KeyPressEventArgs e)//Se crea un evento que se ejecuta al presionar una tecla
        {//Se abre el espacio del evento
            if (checkBoxInvitado.Checked == true)//Se crea una verificación en caso de estar activado el modo invitado
            {//Se abre el bloque de ejecución de la condición
                if (e.KeyChar >= 00 && e.KeyChar!=8 && e.KeyChar <= 64 || e.KeyChar != 8 && e.KeyChar >= 91 && e.KeyChar <= 96 //Se crea una condición donde solo se pueden escribir
                    || e.KeyChar != 8 && e.KeyChar >= 123 && e.KeyChar <= 126 || e.KeyChar !=8 && e.KeyChar >= 128 )//letras mayúsculas y minúsculas y para borrar retroceso y eliminar
                {//Se abre el bloque de ejecución de la condición
                    e.Handled = true;//Se bloquea el uso de caractéres al cumplirse la condición
                    string ErrorInvitado = string.Format("Solo puede escribir letras mayúsculas y minúsculas en el nombre"); //Se guarda un mensaje que indica si no se escribe
                    //mayúsculas o minúsculas
                    DialogResult CerrarVentana = MessageBox.Show(ErrorInvitado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Se muestra el mensaje previamente guardado
                }//Se abre el bloque de ejecución de la condición
            }//Se cierrra el bloque de ejecución de la condición principal
            if (checkBoxInvitado.Checked == false)//Se crea una verificación en caso de no estar activado el modo invitado
            {//Se abre el bloque de ejecución de la condición
                if (e.KeyChar >= 00 &&  e.KeyChar != 8&&  e.KeyChar <= 47 && e.KeyChar!=127 || e.KeyChar != 8&& e.KeyChar >= 58 && e.KeyChar != 127  )
                {//Se abre el bloque de ejecución de la condición
                    e.Handled = true;//Se bloquea el uso de caractéres al cumplirse la condición
                    string ErrorUsuario = string.Format("Solo puede escribir números");//Se guarda un mensaje que indica la única escritura de números
                    DialogResult CerrarVentana = MessageBox.Show(ErrorUsuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Se muestra el mensaje previamente guardado
                }//Se cierra el espacio de ejecución de la condición
            }//Se cierra el espacio de ejecución de la condición principal
        }//Se cierra el espacio del evento
        private void txtUsuarioIngreso_Leave(object sender, EventArgs e)//Se crea un evento que se ejecuta al no estar posicionado en el texto
        {//Se abre el espacio del evento
            if (txtUsuarioIngreso.Text == string.Empty && checkBoxInvitado.Checked == false)//Se hace una verificación en caso de estar
                //vacía la caja de texto y que no se encuentre en el modo invitado
            {//Se abre el bloque de ejecución de la condición
                txtUsuarioIngreso.Text = "Ingresa tu matrícula o número de empleado";//Se escribe en la caja de texto una instrucción
                txtUsuarioIngreso.ForeColor = Color.Gray;//Se cambia el color del texto a gris
            }//Se cierra el espacio de ejecución de la condición
            if (txtUsuarioIngreso.Text == string.Empty && checkBoxInvitado.Checked == true)//Se hace una verificación en caso de estar
                //vacía la caja de texto y que si se encuentre activado el modo invitado
            {//Se abre el bloque de ejecución de la condición
                txtUsuarioIngreso.Text = "Ingresa tu nombre de invitado";//Se escribe en la caja de texto una instrucción
                txtUsuarioIngreso.ForeColor = Color.Gray;//Se cambia el color del texto a gris
            }//Se cierra el espacio de ejecución de la condición
        }//Se cierra el espacio del evento
        private void txtUsuarioIngreso_Enter(object sender, EventArgs e)//Se crea un evento al ingresar a la caja de texto
        {//Se abre el espacio del evento
            txtUsuarioIngreso.ForeColor = Color.Black;//Se cambia el color a negro en caso de ingresar el texto
        }//Se cierra el espacio del evento
        private void FrmAcceder_Load(object sender, EventArgs e)//Se crea un evento al momento de que se cargue la forma para ingresar
        {//Se abre el espacio del evento
            btnAceptar.BackgroundImage = Properties.Resources.Seleccionar;//Se asigna una imagen indicando una selección al botón
            btnSalir.BackgroundImage = Properties.Resources.Presionar;//Se asigna una imagen indicando que se presione el botón
            btnAceptar.BackgroundImageLayout = ImageLayout.Zoom;//Se ajusta la imagen en el botón
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;//Se ajusta la imagen en el botón
            btnAceptar.Text = string.Empty;//Se vacía el texto que existía en el botón para mostrar la imagen
            btnSalir.Text = string.Empty;//Se vacía el texto que existía en el botón para mostrar la imagen
        }//Se cierra el espacio del evento
        private void btnAceptar_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón
        {//Se abre el espacio del evento
            btnAceptar.BackgroundImage = Properties.Resources.Seleccionar;//Se coloca una imagen sobre el botón representando una selección
        }//Se cierra el espacio del evento
        private void btnAceptar_MouseHover(object sender, EventArgs e)//Se crea un evento cuando el mouse está sobre el botón un tiempo
        {//Se abre el espacio del evento
            btnAceptar.BackgroundImage = Properties.Resources.Mano;//Se coloca una imagen sobre el botón representando una mano
        }//Se cierra el espacio del evento
        private void btnSalir_MouseHover(object sender, EventArgs e)//Se crea un evento cuando el mouse está sobre el botón sobre un tiempo
        {//Se abre el espacio del evento
            btnSalir.BackgroundImage = Properties.Resources.Clic;//Se coloca una imagen sobre el botón representando un clic
        }//Se cierra el espacio del evento
        private void btnSalir_MouseLeave(object sender, EventArgs e)//Se crea un evento cuando el mouse no está en el botón
        {//Se abre el espacio del evento
            btnSalir.BackgroundImage = Properties.Resources.Presionar;//Se coloca una imagen sobre el botón 
        }//Se cierra el espacio del evento
        private void btnSalir_Click(object sender, EventArgs e)//Se crea un evento cuando se presiona el botón de salir
        {//Se abre el espacio del evento
            string SalirPrograma = String.Format("¿Deseas salir del programa?");//Se guarda un texto con formato que menciona la salida del programa
            DialogResult OpcionesSalir = MessageBox.Show(SalirPrograma, "Salir", MessageBoxButtons.YesNo);//Se muestra el mensaje anterior
            //con los botones de si y no
            if (OpcionesSalir == DialogResult.Yes)//Se ejecuta una condición en caso de presionarse si
            {//Se abre el espacio de ejecución de la condición
                Application.Exit();//Se cierra el programa
            }//Se cierra el espacio de ejecución de la condición
            if (OpcionesSalir == DialogResult.No)//Se ejecuta una condición en caso de presionarse no
            {//Se abre el espacio de ejecución de la condición
                return;//Se regresa a la forma original
            }//Se cierra el espacio de ejecución de la condición
        }//Se cierra el espacio del evento

  
    }//Se cierra el objeto de la clse
}//Se cierra un espacio que contiene lo dirigido hacia la referencia con el namespace