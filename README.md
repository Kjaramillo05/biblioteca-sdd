## BibliotecaSD - Proyecto con Specs y WinForms

Este repositorio contiene el proyecto **BibliotecaSD**, desarrollado como parte de la práctica de programación avanzada.  
Incluye especificaciones (SSD y Specs), un pipeline de integración continua con GitHub Actions, y una aplicación ejecutable en **Windows Forms**.

---

## Funcionalidad
La aplicación permite:
- Registrar préstamos de libros a estudiantes.
- Visualizar los préstamos registrados en un formulario.
- Interactuar mediante una interfaz gráfica sencilla (WinForms).

---

## Estructura del repositorio

## Flujo de trabajo

1. **Especificaciones**  
   - Se crean en la carpeta `/specs` en formato YAML o Markdown.  
   - Cada nueva funcionalidad se describe primero como especificación.

2. **Generación de código**  
   - La IA genera el código en `/src` a partir de las especificaciones.  
   - El código se revisa antes de integrarse a la rama principal.

3. **Control de versiones**  
   - Cada cambio se hace en una rama nueva.  
   - Se abre un Pull Request para revisión.  
   - Una vez aprobado, se integra a la rama `principal`.

4. **Pipeline (CI/CD)**  
   - Los pipelines están en `.github/workflows`.  
   - Al hacer push o PR, GitHub Actions compila y ejecuta pruebas automáticamente.

5. **Documentación**  
   - Las especificaciones y el flujo de trabajo se mantienen actualizados en este repositorio.
Pipeline activado con GitHub Actions 🚀
