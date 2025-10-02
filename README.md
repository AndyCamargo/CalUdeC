CalUdeC - Aplicación de Realidad Aumentada para Cálculo
Aplicación móvil educativa desarrollada en Unity con Vuforia que utiliza Realidad Aumentada (AR) para enseñar conceptos de cálculo diferencial e integral de manera interactiva.
📋 Descripción
CalUdeC es una herramienta educativa innovadora que combina la tecnología de Realidad Aumentada con el aprendizaje de cálculo. Los estudiantes pueden visualizar funciones matemáticas, gráficas y ejercicios en 3D mediante el escaneo de marcadores específicos.
✨ Características Principales
🎯 Funcionalidades

Realidad Aumentada: Visualización 3D de funciones y gráficas matemáticas
30 Ejercicios: Conjunto completo de ejercicios de cálculo diferencial e integral
30 Gráficas: Representaciones visuales interactivas de funciones
Sistema de Usuarios: Gestión de perfiles de administrador y usuario
Módulo de Ayuda: Guías integradas para uso de la aplicación
Seguimiento de Progreso: Registro de ejercicios completados

👥 Roles de Usuario

Administrador

Gestión completa de ejercicios
Visualización de estadísticas
Control de usuarios


Usuario/Estudiante

Acceso a ejercicios
Visualización de gráficas en AR
Seguimiento de progreso personal



🚀 Tecnologías Utilizadas
Motor y Frameworks

Unity 2018.2.1f1: Motor de desarrollo principal
C# (.NET 3.5): Lenguaje de programación
Vuforia SDK: Framework de Realidad Aumentada
MonoDevelop: IDE integrado

Plataformas Objetivo

Android (Principal)

SDK Mínimo: Android 6.0 (API 23)
Target: Configuración automática


Windows Standalone (Desarrollo)

Módulos Unity Utilizados

AR Module
Physics Module
UI Module
Animation Module
Video Module

📁 Estructura del Proyecto
CalUdeC/
│
├── Assets/
│   ├── Scripts/
│   │   ├── Login.cs                 # Sistema de autenticación
│   │   ├── Menu_admin.cs           # Menú de administrador
│   │   ├── Menu_usuario.cs         # Menú de usuario
│   │   ├── Registro_admin.cs       # Registro de admin
│   │   ├── Registros.cs            # Gestión de registros
│   │   ├── usuario.cs              # Gestión de usuarios
│   │   ├── Ejercicio.cs            # Lógica de ejercicios
│   │   ├── Lista_Funciones.cs      # Catálogo de funciones
│   │   ├── colores.cs              # Gestión de colores UI
│   │   └── volver.cs               # Navegación
│   │
│   ├── Scenes/
│   │   ├── Login.unity             # Escena de inicio de sesión
│   │   ├── Menu_usuario.unity      # Menú principal usuario
│   │   ├── Menu_admin.unity        # Menú principal admin
│   │   ├── Registro_usuario.unity  # Registro de usuario
│   │   ├── Registro_admin.unity    # Registro de admin
│   │   ├── Lista_Funciones.unity   # Lista de ejercicios
│   │   ├── Ayuda.unity            # Ayuda 1
│   │   ├── Ayuda2.unity           # Ayuda 2
│   │   ├── Ejercicio_1.unity      # Ejercicios (1-30)
│   │   ├── ...
│   │   ├── Ejercicio_30.unity
│   │   ├── Grafica_1.unity        # Gráficas (1-30)
│   │   ├── ...
│   │   └── Grafica_30.unity
│   │
│   ├── Vuforia/
│   │   ├── Scripts/
│   │   │   ├── DefaultTrackableEventHandler.cs
│   │   │   └── DefaultInitializationErrorHandler.cs
│   │   └── Shaders/               # Shaders para AR
│   │
│   └── StreamingAssets/
│       └── Vuforia/
│           ├── VuforiaMars_ModelTarget.xml
│           ├── VuforiaMars_Images.xml
│           ├── VuforiaMars_VuMark.xml
│           ├── VuforiaMars_Object_OT.xml
│           └── UdeCal.xml
│
├── ProjectSettings/              # Configuraciones de Unity
│   ├── ProjectSettings.asset
│   ├── EditorBuildSettings.asset
│   ├── QualitySettings.asset
│   └── ...
│
├── QCAR/                        # Datos de Vuforia
│
└── Library/                     # Archivos generados (ignorar en git)
🎮 Escenas del Proyecto
Escenas Principales

Login - Autenticación de usuarios
Menu_usuario - Dashboard del estudiante
Menu_admin - Panel de administración
Lista_Funciones - Catálogo de ejercicios disponibles

Escenas de Ejercicios (30)

Ejercicio_1 a Ejercicio_30: Problemas de cálculo diferencial e integral

Escenas de Gráficas (30)

Grafica_1 a Grafica_30: Visualizaciones AR de funciones matemáticas

Escenas de Soporte

Ayuda, Ayuda2: Tutoriales de uso
Registro_usuario, Registro_admin: Creación de cuentas

💻 Requisitos del Sistema
Para Desarrollo

Unity 2018.2.1f1 o superior
Visual Studio 2017 o superior (opcional)
Vuforia Engine (integrado)
Android SDK y NDK (para compilar Android)
JDK 8 o superior

Especificaciones Mínimas PC Desarrollo

Windows 7 SP1+ (64-bit)
Procesador: Core i5 o equivalente
RAM: 8 GB
Espacio: 5 GB disponibles
GPU: Compatible con DirectX 11

Para Dispositivos Android

Android 6.0 (Marshmallow) o superior
Cámara trasera funcional
Acelerómetro y giroscopio
2 GB RAM mínimo
500 MB espacio disponible

🔧 Instalación y Configuración
1. Clonar el Repositorio
bashgit clone [url-del-repositorio]
cd CalUdeC
2. Abrir en Unity

Abrir Unity Hub
Agregar proyecto existente
Seleccionar la carpeta CalUdeC
Unity descargará los módulos necesarios

3. Configurar Vuforia

Crear cuenta en Vuforia Developer Portal
Obtener License Key
En Unity: Window > Vuforia Configuration
Pegar License Key
Configurar targets/marcadores

4. Configuración de Build Android
Instalar Android Build Support

File > Build Settings > Android
Si no está instalado, Unity Hub instalará módulos

Configurar Player Settings
File > Build Settings > Player Settings

Package Name: com.UdeC.Product
Version: 3.5
Minimum API Level: Android 6.0 (API 23)
Target API Level: Automatic
Permisos Necesarios

Camera
Internet (si aplica)
Write External Storage (si aplica)

🏗️ Compilación
Build para Android
1. File > Build Settings
2. Seleccionar "Android"
3. Switch Platform (si no está activo)
4. Player Settings:
   - Company Name: DefaultCompany
   - Product Name: CalUdeC
   - Icon: Configurar
5. Build o Build and Run
Build para Windows (Testing)
1. File > Build Settings
2. Seleccionar "PC, Mac & Linux Standalone"
3. Target Platform: Windows
4. Architecture: x86_64
5. Build
📱 Uso de la Aplicación
Flujo de Usuario

Inicio de Sesión

Ingresar credenciales
o Registrar nuevo usuario


Menú Principal

Seleccionar "Ejercicios" o "Gráficas"
Acceder a "Ayuda" si es necesario


Visualización AR

Apuntar cámara al marcador correspondiente
Observar modelo 3D
Interactuar con el contenido


Completar Ejercicio

Resolver problema
Validar respuesta
Ver retroalimentación



Marcadores Vuforia
Los marcadores están configurados en:

StreamingAssets/Vuforia/UdeCal.xml
StreamingAssets/Vuforia/VuforiaMars_Images.xml

Imprimir o mostrar digitalmente los marcadores correspondientes a cada ejercicio.
🎯 Scripts Principales
Login.cs
Maneja la autenticación de usuarios y validación de credenciales.
Menu_usuario.cs / Menu_admin.cs
Controlan la navegación y opciones disponibles según el rol.
Ejercicio.cs
Lógica core de los ejercicios: validación, puntuación, progreso.
Lista_Funciones.cs
Gestiona el catálogo de funciones matemáticas disponibles.
DefaultTrackableEventHandler.cs (Vuforia)
Detecta y maneja eventos cuando se reconoce un marcador AR.
🔐 Sistema de Usuarios
Base de Datos
El sistema utiliza almacenamiento local (PlayerPrefs o SQLite según implementación).
Tipos de Cuenta

Administrador

Acceso completo
Gestión de contenido
Estadísticas globales


Usuario

Acceso a ejercicios
Progreso personal
Visualización de gráficas



📊 Módulos de Ejercicios
Cálculo Diferencial

Límites
Derivadas
Aplicaciones de derivadas
Optimización

Cálculo Integral

Integrales definidas
Integrales indefinidas
Aplicaciones de integrales
Métodos de integración

🎨 Recursos Visuales
Gráficas 3D
Cada ejercicio tiene una representación visual en AR:

Funciones lineales
Funciones cuadráticas
Funciones trigonométricas
Funciones exponenciales
Superficies

🐛 Solución de Problemas Comunes
Vuforia no reconoce marcadores

Verificar License Key en Vuforia Configuration
Asegurar buena iluminación
Verificar que la cámara tenga permisos
Actualizar database de targets

Error de compilación Android

Verificar instalación de Android SDK
Actualizar Build Tools
Verificar Path de JDK
Limpiar caché: Edit > Preferences > External Tools

App crashea al iniciar

Verificar permisos de cámara en dispositivo
Comprobar versión mínima de Android
Revisar logs: adb logcat

📝 Desarrollo y Contribución
Agregar Nuevo Ejercicio

Duplicar escena de ejercicio existente
Modificar GameObject con nuevo contenido
Actualizar EditorBuildSettings.asset
Crear marcador Vuforia correspondiente
Actualizar Lista_Funciones.cs

Agregar Nueva Gráfica

Crear nueva escena desde template
Diseñar modelo 3D de la función
Configurar tracking de marcador
Añadir a build settings

📄 Archivos de Configuración
ProjectSettings/ProjectSettings.asset
Configuración principal del proyecto Unity.
ProjectSettings/EditorBuildSettings.asset
Lista de escenas incluidas en el build (68 escenas configuradas).
QCAR/somedata16
Datos encriptados de licencia Vuforia.
🔄 Versiones

Versión Actual: 3.5
Unity: 2018.2.1f1
Vuforia: Incluido con Unity
Android Bundle Version: 3

📞 Soporte y Contacto

Universidad: Universidad de Cartagena (UdeC)
Proyecto: CalUdeC - Cálculo AR
Tipo: Proyecto educativo/académico

📜 Licencia
Este proyecto es un trabajo académico. Todos los derechos reservados a sus creadores y la Universidad de Cartagena.
🙏 Agradecimientos

Universidad de Cartagena
Equipo de desarrollo CalUdeC
Comunidad de Vuforia
Unity Technologies


Nota: Este proyecto fue desarrollado con fines educativos para facilitar el aprendizaje del cálculo mediante tecnología de Realidad Aumentada.
📚 Recursos Adicionales

Documentación de Unity
Vuforia Engine Developer Portal
Android Developers
