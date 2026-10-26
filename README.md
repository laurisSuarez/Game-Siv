# Students Interactive Video Games

**Videojuego educativo interactivo para el aprendizaje del inglés**

## 1. Descripción del proyecto

**Students Interactive Video Games** es un proyecto académico de desarrollo de software orientado al diseño de un videojuego educativo 2D que busca apoyar el proceso de enseñanza-aprendizaje del inglés en estudiantes de primaria de la Institución Educativa ICAM, ubicada en Ubaté, Colombia.

La propuesta surge de la necesidad de fortalecer el aprendizaje del inglés mediante experiencias interactivas que complementen las metodologías tradicionales de enseñanza. Para ello, el videojuego plantea actividades educativas organizadas progresivamente, con ejercicios que permiten practicar vocabulario, gramática y estructuras básicas del idioma.

El proyecto integra elementos de gamificación, como niveles, desafíos y actividades interactivas, con el propósito de favorecer la participación, la motivación y la práctica del idioma en un entorno digital.

El desarrollo contempla tres niveles de aprendizaje, organizados de acuerdo con la progresión de los contenidos educativos y las necesidades identificadas durante el diagnóstico del proyecto.

## 2. Objetivos del proyecto

### Objetivo general

Desarrollar un videojuego educativo para la enseñanza-aprendizaje del vocabulario, la gramática y las estructuras básicas del inglés en estudiantes de la Institución Educativa ICAM, mediante actividades interactivas que favorezcan el aprendizaje progresivo del idioma.

### Objetivos específicos

1. Identificar las falencias que presenta la Institución Educativa ICAM en el proceso de enseñanza-aprendizaje del inglés como segunda lengua, mediante la aplicación de encuestas a estudiantes y docentes durante la fase de diagnóstico del proyecto.
2. Diseñar y estructurar el contenido educativo de los tres niveles del videojuego, incorporando actividades interactivas de vocabulario, gramática y estructuras básicas del inglés, de acuerdo con las necesidades de aprendizaje identificadas durante las fases de diseño y desarrollo del prototipo.
3. Evaluar los resultados del uso del videojuego educativo en el aprendizaje del inglés de los estudiantes de la Institución Educativa ICAM, mediante la aplicación de pruebas antes y después de su utilización y el análisis de los resultados obtenidos durante la fase de evaluación del proyecto.

## 3. Público objetivo

El videojuego está dirigido principalmente a estudiantes de primaria, con una población objetivo aproximada de entre 5 y 12 años.

La propuesta contempla la participación de docentes de inglés y personal de apoyo pedagógico para orientar, revisar y validar los contenidos educativos del videojuego.

## 4. Alcance del proyecto

El alcance contempla el diseño y desarrollo progresivo de un prototipo de videojuego educativo 2D que permita integrar actividades de aprendizaje del inglés mediante una experiencia interactiva.

Entre los componentes contemplados se encuentran:

- Un menú principal para acceder a las opciones del videojuego.
- Una organización del contenido educativo en tres niveles.
- Actividades de vocabulario, gramática y estructuras básicas del inglés.
- Ejercicios interactivos adaptados a la progresión del aprendizaje.
- Navegación entre las pantallas y actividades.
- Mecanismos de respuesta y retroalimentación para apoyar el aprendizaje.
- Elementos de gamificación que favorezcan la participación del estudiante.
- Pruebas funcionales y evaluación educativa del prototipo.

El alcance definitivo de cada funcionalidad depende de su implementación y validación durante el desarrollo.

## 5. Organización de los niveles educativos

El videojuego propone tres niveles con contenidos progresivos.

| Nivel   | Población orientativa | Contenidos y actividades                                                                |
| ------- | --------------------- | --------------------------------------------------------------------------------------- |
| Nivel 1 | 5 a 7 años            | Colores, animales, partes del cuerpo, saludos, números y países.                        |
| Nivel 2 | 7 a 10 años           | Vocabulario, completar textos, relacionar palabras con historias y responder preguntas. |
| Nivel 3 | 10 a 12 años          | Crucigramas, completar textos, responder preguntas, diálogos y sopas de letras.         |

*Nota:* Las edades son orientativas y pueden ajustarse de acuerdo con el grado escolar, el diagnóstico pedagógico y la validación de los contenidos.

## 6. Tecnologías y herramientas

Las herramientas previstas para el desarrollo y la documentación del proyecto son las siguientes:

| Tecnología o herramienta                       | Propósito                                                                                         |
| ---------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| Construct 3                                    | Desarrollo del videojuego 2D mediante eventos, objetos y lógica interactiva.                      |
| HTML5 y JavaScript                             | Tecnologías asociadas a la ejecución web del videojuego exportado por Construct 3.                |
| Navegador web                                  | Ejecución y verificación del videojuego exportado.                                                |
| Git y GitHub                                   | Control de versiones y gestión del código y los archivos del proyecto, cuando estén configurados. |
| Herramientas de diseño visual                  | Elaboración de mockups, personajes, pantallas y recursos gráficos.                                |
| Herramientas de hojas de cálculo o formularios | Organización y análisis de encuestas y pruebas de evaluación.                                     |

La utilización de una base de datos, un servidor o un sistema de persistencia dependerá de los componentes que se implementen efectivamente en el proyecto.

## 7. Arquitectura del software

Se propone una arquitectura modular organizada por responsabilidades. Esta separación facilita el mantenimiento, las pruebas y la incorporación progresiva de nuevas actividades educativas.

### 7.1. Módulo de presentación e interacción

Se encarga de mostrar los elementos visuales del videojuego y permitir la interacción del estudiante con los menús, botones, personajes, objetos y actividades.

### 7.2. Módulo de lógica del videojuego

Gestiona el comportamiento de los elementos interactivos, las condiciones de las actividades, la navegación entre pantallas y las reglas de funcionamiento.

### 7.3. Módulo de aprendizaje

Organiza los contenidos educativos, las preguntas, las respuestas y las actividades de vocabulario, gramática y estructuras básicas del inglés.

### 7.4. Módulo de datos

Organiza la información que necesita el videojuego, como preguntas, opciones de respuesta, respuestas correctas y contenidos por nivel.

La persistencia de puntuaciones o del progreso individual requiere una implementación adicional cuando los datos deban conservarse entre sesiones.

**Importante:** Esta arquitectura describe la organización propuesta para el desarrollo. Su correspondencia exacta con los eventos, objetos y archivos existentes debe verificarse en el proyecto de Construct 3.

## 8. Requisitos para la ejecución

Para ejecutar el videojuego se debe contar con:

- Un computador con Windows, Linux o macOS.
- Un navegador web moderno y actualizado.
- Los archivos del proyecto o una versión web exportada del videojuego.
- Conexión a Internet para acceder al editor en línea de Construct 3 y a los recursos externos que el proyecto requiera.

Si se desea editar el videojuego, se necesita acceso al proyecto original y al editor Construct 3.

Si únicamente se desea jugar, basta con disponer de una versión exportada y ejecutable del videojuego.

## 9. Instalación y ejecución

### 9.1. Obtener los archivos del proyecto

Clona el repositorio de GitHub o descarga el código fuente y descomprímelo en una carpeta local.

```bash
git clone URL_DEL_REPOSITORIO
cd CARPETA_DEL_PROYECTO
```

Reemplaza `URL_DEL_REPOSITORIO` por la dirección real del repositorio y `CARPETA_DEL_PROYECTO` por el nombre de la carpeta creada.

Si el proyecto no utiliza Git, puedes descargar los archivos directamente desde el repositorio o recibir la carpeta original del proyecto.

### 9.2. Abrir el proyecto en Construct 3

1. Accede al editor oficial: [https://editor.construct.net/](https://editor.construct.net/)
2. Abre el proyecto original desde el editor mediante la opción disponible para cargar un proyecto existente.
3. Selecciona el archivo o la carpeta del proyecto de acuerdo con el formato en el que se encuentre almacenado.
4. Espera a que el editor cargue las escenas, los objetos, los recursos gráficos y las hojas de eventos.
5. Comprueba que no existan recursos faltantes ni errores de carga.

El archivo original puede ser un proyecto `.c3p` o una carpeta de proyecto, según la forma en que se haya guardado.

### 9.3. Ejecutar el videojuego en modo de prueba

Una vez abierto el proyecto:

1. Localiza la opción **Preview** o **Vista previa** en Construct 3.
2. Ejecuta la vista previa.
3. Espera a que se abra la ventana del navegador.
4. Comprueba que aparezca el menú principal.
5. Navega por las pantallas y verifica las interacciones implementadas.
6. Prueba las actividades disponibles y revisa que las respuestas y la navegación funcionen correctamente.

La vista previa permite realizar pruebas durante el desarrollo sin necesidad de exportar una versión final.

### 9.4. Exportar el videojuego para su distribución

Cuando exista una versión funcional que se desee compartir:

1. Abre el proyecto en Construct 3.
2. Selecciona la opción de exportación.
3. Elige el destino web HTML5, si está disponible para el proyecto.
4. Configura las opciones de exportación necesarias.
5. Genera los archivos de salida.
6. Guarda la exportación en una carpeta independiente del proyecto fuente.

La exportación web normalmente genera un archivo `index.html` y los recursos necesarios para ejecutar el videojuego.

### 9.5. Ejecutar la versión exportada

La versión exportada debe servirse mediante un servidor web local o publicarse en un servidor compatible con HTML5.

No se recomienda abrir directamente `index.html` mediante una ruta `file://`, porque algunas funciones del navegador pueden impedir la carga de recursos o el funcionamiento de determinadas características.

Si Python está instalado, puedes iniciar un servidor HTTP local desde la carpeta exportada:

```bash
python -m http.server 8000
```

Si tu sistema utiliza el comando `python3`, ejecuta:

```bash
python3 -m http.server 8000
```

Después, abre el siguiente enlace en el navegador:

[http://localhost:8000](http://localhost:8000)

Asegúrate de ejecutar el comando desde la carpeta que contiene el archivo `index.html`.

Para detener el servidor, vuelve a la terminal y presiona `Ctrl + C`.

**Nota:** Este servidor sirve los archivos de la exportación web; no instala ni ejecuta una base de datos o un backend.

## 10. Flujo de uso del videojuego

El flujo general previsto para el estudiante es el siguiente:

1. **Inicio:** ingresar al videojuego y visualizar el menú principal.
2. **Selección:** acceder al nivel o actividad disponible.
3. **Instrucciones:** consultar las indicaciones de la actividad, cuando estén implementadas.
4. **Interacción:** resolver los ejercicios propuestos de inglés.
5. **Retroalimentación:** recibir información sobre las respuestas, de acuerdo con las funciones desarrolladas.
6. **Continuación:** avanzar a otra actividad o nivel según las reglas implementadas.
7. **Finalización:** consultar el resultado de la actividad si el sistema dispone de esta funcionalidad.

Este flujo representa el comportamiento esperado del videojuego y no implica que todas sus etapas estén implementadas en la versión actual.

## 11. Pruebas y validación

La validación del videojuego contempla dos dimensiones principales.

### 11.1. Pruebas funcionales

Permiten comprobar que las funcionalidades implementadas respondan correctamente.

Entre las verificaciones previstas se encuentran:

- Carga correcta del menú principal.
- Navegación entre las pantallas disponibles.
- Apertura de las actividades.
- Funcionamiento de los controles interactivos.
- Validación de las respuestas de los ejercicios.
- Visualización de la retroalimentación, cuando corresponda.
- Funcionamiento de la puntuación y del avance, si están implementados.
- Ausencia de errores que impidan continuar la actividad.

### 11.2. Evaluación educativa

Busca analizar el aporte del videojuego al aprendizaje del inglés mediante la aplicación de pruebas antes y después de su utilización.

Los resultados deberán analizarse para identificar posibles cambios en el desempeño de los estudiantes, teniendo en cuenta las características de la muestra, los contenidos evaluados y las condiciones de aplicación.

No se deben atribuir mejoras al videojuego sin recopilar y analizar previamente los resultados de la evaluación.

## 12. Metodología de desarrollo

El desarrollo del proyecto se organiza mediante un enfoque de trabajo iterativo basado en Scrum, con actividades de planificación, diseño, desarrollo, revisión y pruebas.

Las etapas contempladas incluyen:

1. **Diagnóstico:** identificación de las dificultades de aprendizaje del inglés y recopilación de información de estudiantes y docentes.
2. **Diseño:** elaboración de mockups, definición de los contenidos educativos y organización de los niveles.
3. **Desarrollo del prototipo:** construcción de las pantallas, la navegación y las actividades interactivas.
4. **Integración:** incorporación progresiva de los contenidos, las reglas de interacción y los componentes de apoyo al aprendizaje.
5. **Pruebas:** verificación funcional y corrección de errores.
6. **Evaluación:** aplicación de instrumentos de evaluación y análisis de los resultados obtenidos.

Las actividades se desarrollan progresivamente y su estado debe actualizarse de acuerdo con los avances reales del equipo.

## 13. Estructura sugerida del repositorio

La siguiente estructura es una propuesta para organizar los archivos. Debe ajustarse a la estructura real del proyecto.

```text
students-interactive-video-games/
├── README.md
├── docs/
│   ├── arquitectura.md
│   ├── requisitos.md
│   ├── historias-de-usuario.md
│   └── pruebas.md
├── design/
│   ├── mockups/
│   └── recursos-visuales/
├── game/
│   └── proyecto-construct3.c3p
└── release/
    └── README.md
```

**Descripción de las carpetas:**

- `docs/`: documentación técnica y funcional del proyecto.
- `design/`: mockups, diseños de pantallas y recursos visuales.
- `game/`: archivo fuente del videojuego, si se utiliza un proyecto `.c3p`.
- `release/`: versiones exportadas y preparadas para distribución, si se decide almacenarlas en el repositorio.
- `README.md`: descripción principal e instrucciones generales del proyecto.

Los nombres y archivos son ilustrativos. No es necesario crear archivos adicionales que todavía no existan.

## 14. Limitaciones del proyecto

Las limitaciones deben actualizarse conforme avance el desarrollo. Entre los aspectos que requieren atención se encuentran:

- La disponibilidad de equipos y navegadores compatibles en el entorno educativo.
- La necesidad de validar pedagógicamente los contenidos antes de su utilización con estudiantes.
- La adaptación de las actividades a las edades y los niveles de conocimiento del inglés.
- La verificación del funcionamiento en diferentes tamaños de pantalla y navegadores.
- La necesidad de implementar y probar cualquier mecanismo de persistencia si se requiere guardar el progreso.
- La disponibilidad de resultados suficientes para evaluar el efecto educativo del videojuego.

El prototipo no debe considerarse un sustituto del docente, sino un recurso complementario para apoyar la enseñanza del inglés.

## 15. Estado del proyecto

El proyecto se encuentra en desarrollo académico. Su avance comprende actividades de diagnóstico, definición de contenidos, diseño de interfaces y construcción progresiva del prototipo.

Los siguientes componentes deben marcarse como terminados únicamente después de verificar su implementación:

- [ ] Menú principal funcional.
- [ ] Navegación entre pantallas.
- [ ] Tres niveles educativos integrados.
- [ ] Actividades de inglés funcionales.
- [ ] Validación de respuestas y retroalimentación.
- [ ] Puntuación y avance entre actividades.
- [ ] Pruebas funcionales documentadas.
- [ ] Evaluación educativa mediante pruebas iniciales y finales.

Esta lista permite mantener la documentación sincronizada con el avance real del desarrollo.

## 16. Contribuciones y mantenimiento

Las modificaciones del proyecto deben realizarse de manera organizada para conservar la integridad del videojuego y su documentación.

Se recomienda:

- Mantener una copia del proyecto fuente antes de realizar cambios importantes.
- Utilizar control de versiones cuando el repositorio esté configurado.
- Documentar las nuevas funcionalidades.
- Probar las actividades afectadas por cada modificación.
- Verificar la integridad de los recursos gráficos y educativos.
- Mantener separados los archivos fuente y las versiones exportadas.
- Registrar los errores identificados y las correcciones realizadas.

Las contribuciones deben respetar los objetivos pedagógicos y los contenidos definidos para el proyecto.

## 17. Consideraciones de privacidad

Debido a que el videojuego está dirigido a menores de edad, cualquier recopilación de información de los estudiantes debe realizarse de acuerdo con las autorizaciones institucionales correspondientes y las normas de protección de datos aplicables.

Se recomienda no incorporar datos personales identificables en los archivos del repositorio. Si se implementan registros de resultados o seguimiento individual, deberán definirse las medidas necesarias para proteger esa información.

## 18. Licencia

La licencia del proyecto debe definirse de acuerdo con las decisiones del equipo y los lineamientos de la institución educativa.

Hasta que se determine una licencia formal, no debe asumirse que el código, los recursos gráficos o los contenidos pueden reutilizarse libremente por terceros.

## 19. Autoría y contexto académico

**Proyecto:** Students Interactive Video Games
**Área:** Ingeniería de Sistemas y Computación
**Institución académica:** Universidad de Cundinamarca
**Institución educativa vinculada:** Institución Educativa ICAM
**Ubicación del proyecto de investigación:** Ubaté, Colombia
**Propósito:** apoyar la enseñanza-aprendizaje del inglés mediante un videojuego educativo interactivo.

