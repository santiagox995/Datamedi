# Tabla de usuarios (medicos)
## usuarios
* id-int 
* nombre-varchar(100)
* apellido-varchar(100)
* email-varchar(150) correo
* passwordhash(255) contraseña cifrada
* fechaRegistro Date
* Telefono varchar(20) 

## pacientes

* Id	INT	Identificador del paciente
* UsuarioId	INT	Médico propietario
* Nombre	VARCHAR(100)	Nombre
* Apellido	VARCHAR(100)	Apellido
* Documento	VARCHAR(20)	Documento identidad
* FechaNacimiento	DATE	Fecha nacimiento
* Sexo	VARCHAR(20)	Sexo
* Telefono	VARCHAR(20)	Contacto
* Direccion	VARCHAR(200)	Dirección
* Correo	VARCHAR(150)	Correo
* TipoSangre	VARCHAR(5)	Tipo sanguíneo
* FechaRegistro	DATE	Fecha registro

## consultas

* Id	INT
* PacienteId	INT
* FechaConsulta	DATE
* Motivo	TEXT
* Diagnostico	TEXT
* Medicamentos	TEXT	
* Alergias	TEXT	
* Tratamiento	TEXT
* Observaciones	TEXT

## citas
* Id	INT
* PacienteId	INT
* Fecha	DATE
* Hora	TIME
* Motivo	TEXT
* Estado	VARCHAR(30)
