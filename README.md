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
```bash
git clone [url-del-repositorio]
cd CalUdeC


Abrir en Unity

Abrir Unity Hub → Agregar proyecto → Seleccionar carpeta.

Configurar Vuforia

Obtener License Key en Vuforia Developer Portal
.

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
