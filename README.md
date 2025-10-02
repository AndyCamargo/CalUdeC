# 📱 CalUdeC - Aplicación de Realidad Aumentada para Cálculo  

Aplicación móvil educativa desarrollada en **Unity con Vuforia** que utiliza **Realidad Aumentada (AR)** para enseñar conceptos de cálculo diferencial e integral de manera interactiva.  

---

## 📋 Descripción  
**CalUdeC** es una herramienta educativa innovadora que combina la tecnología de Realidad Aumentada con el aprendizaje de cálculo.  
Los estudiantes pueden visualizar funciones matemáticas, gráficas y ejercicios en **3D** mediante el escaneo de marcadores específicos.  

---

## ✨ Características Principales  

### 🎯 Funcionalidades
- 📊 **Realidad Aumentada:** Visualización 3D de funciones y gráficas matemáticas.  
- 📝 **30 Ejercicios:** Conjunto de cálculo diferencial e integral.  
- 📈 **30 Gráficas:** Representaciones visuales interactivas de funciones.  
- 👥 **Sistema de Usuarios:** Perfiles de administrador y estudiante.  
- 📖 **Módulo de Ayuda:** Guías integradas para el uso de la aplicación.  
- ✅ **Seguimiento de Progreso:** Registro de ejercicios completados.  

### 👥 Roles de Usuario  
**Administrador**
- Gestión completa de ejercicios.  
- Visualización de estadísticas.  
- Control de usuarios.  

**Usuario/Estudiante**
- Acceso a ejercicios y gráficas en AR.  
- Seguimiento de progreso personal.  

---

## 🚀 Tecnologías Utilizadas  

**Motor y Frameworks**  
- Unity 2018.2.1f1  
- C# (.NET 3.5)  
- Vuforia SDK  
- MonoDevelop  

**Plataformas Objetivo**  
- Android (principal)  
- Windows Standalone (desarrollo y pruebas)  

**Módulos Unity**  
- AR Module  
- Physics Module  
- UI Module  
- Animation Module  
- Video Module  

---

## 📁 Estructura del Proyecto  

```
CalUdeC/
├── Assets/
│ ├── Scripts/
│ │ ├── Login.cs
│ │ ├── Menu_admin.cs
│ │ ├── Menu_usuario.cs
│ │ ├── Ejercicio.cs
│ │ └── ...
│ ├── Scenes/
│ │ ├── Login.unity
│ │ ├── Menu_usuario.unity
│ │ ├── Ejercicio_1.unity ... Ejercicio_30.unity
│ │ ├── Grafica_1.unity ... Grafica_30.unity
│ │ └── Ayuda.unity, Ayuda2.unity
│ ├── Vuforia/
│ └── StreamingAssets/
│ └── Vuforia/
│ ├── UdeCal.xml
│ └── ...
├── ProjectSettings/
├── QCAR/
└── Library/ # Ignorar en git

```
Yaml

---

## 🎮 Escenas del Proyecto  
- **Login** – Autenticación de usuarios.  
- **Menu_usuario** – Dashboard del estudiante.  
- **Menu_admin** – Panel de administración.  
- **Lista_Funciones** – Catálogo de ejercicios.  
- **Ejercicio_1 a Ejercicio_30** – Problemas de cálculo.  
- **Grafica_1 a Grafica_30** – Visualizaciones AR.  
- **Ayuda / Ayuda2** – Tutoriales y guías.  

---

## 💻 Requisitos del Sistema  

### Para Desarrollo  
- Unity 2018.2.1f1 o superior  
- Android SDK + NDK  
- JDK 8+  
- Vuforia Engine integrado  

**PC mínimo:**  
- Windows 7 SP1+ (64-bit)  
- Core i5 o equivalente  
- 8 GB RAM  
- GPU compatible con DirectX 11  

### Para Android  
- Android 6.0 (Marshmallow) o superior  
- Cámara trasera funcional  
- Acelerómetro y giroscopio  
- 2 GB RAM mínimo  

---

## 🔧 Instalación y Configuración  

1. **Clonar el repositorio**
bash

git clone [url-del-repositorio]
cd CalUdeC


Abrir en Unity

Abrir Unity Hub → Agregar proyecto → Seleccionar carpeta.
Configurar Vuforia
Obtener License Key en Vuforia Developer Portal.
Unity → Window > Vuforia Configuration → Pegar la Key.
Configurar Build para Android
File > Build Settings > Android → Switch Platform.
Player Settings → Package Name: com.UdeC.Product.

🏗️ Compilación

Android
File > Build Settings > Android.
Switch Platform.
Configurar Company Name, Product Name e íconos.
Build o Build and Run.
Windows (testing)
File > Build Settings > PC, Mac & Linux Standalone.
Target Platform: Windows, Architecture: x86_64.
Build.

📱 Uso de la Aplicación

Login / Registro
Ingresar credenciales o registrar nuevo usuario.
Menú Principal
Acceso a Ejercicios o Gráficas.
Visualización AR
Apuntar cámara al marcador.
Observar e interactuar con el modelo 3D.
Resolución de Ejercicios
Resolver → Validar → Recibir retroalimentación.


🎯 Scripts Principales
Login.cs – Autenticación de usuarios.
Menu_usuario.cs / Menu_admin.cs – Navegación según rol.
Ejercicio.cs – Lógica de ejercicios.
Lista_Funciones.cs – Catálogo de funciones matemáticas.
DefaultTrackableEventHandler.cs – Reconocimiento de marcadores AR.

🔐 Sistema de Usuarios

Administrador
Gestión de ejercicios y usuarios.
Estadísticas globales.
Usuario/Estudiante
Acceso a ejercicios y gráficas.
Seguimiento personal de progreso.

📊 Módulos de Ejercicios

Cálculo Diferencial
Límites
Derivadas
Aplicaciones de derivadas
Optimización
Cálculo Integral
Integrales definidas e indefinidas
Aplicaciones de integrales
Métodos de integración

🐛 Solución de Problemas

Vuforia no reconoce marcadores:
Revisar License Key.
Verificar permisos de cámara.
Mejorar iluminación.
Error de compilación en Android:
Revisar Android SDK y JDK.
Limpiar caché.
App crashea al iniciar:
Verificar versión mínima de Android.
Revisar logs con adb logcat.

📝 Desarrollo y Contribución

Agregar nuevo ejercicio:
Duplicar escena existente.
Crear marcador en Vuforia.
Actualizar Lista_Funciones.cs.
Agregar nueva gráfica:
Crear escena desde template.
Configurar tracking y modelo 3D.
Incluir en Build Settings.

🔄 Versiones

Versión Actual: 3.5
Unity: 2018.2.1f1
Vuforia: Incluido con Unity

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

📚 Recursos Adicionales

<li><a href="https://docs.unity3d.com/" target="_blank" rel="noopener noreferrer">Unity Documentation</a></li>
<li><a href="https://developer.vuforia.com/" target="_blank" rel="noopener noreferrer">Vuforia Developer Portal</a></li>
<li><a href="https://developer.android.com/" target="_blank" rel="noopener noreferrer">Android Developers</a></li>
      
