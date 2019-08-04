//debugger;

var numero = 15;
var cadena = "Hola JavaScript";
var booleanTrue = true;
var booleanFalse = false;
var date = new Date();

//objeto
var alumno = {
    Nombre: "Juan",
    Apellidos: "Días",
    Edad: "13",
    FechaNacimiento: "1980/05/04",
    GenerarNombreCompleto: function (genero) {
        var fullName = this.Nombre + " " + this.Apellidos;

        if (genero == "M") {
            fullName = "Señor: " + fullName;
        }
        else {
            fullName = "Señora: " + fullName;
        }
        return fullName;
    }
};

//arreglo
var clase = [];
//Agregando elementos a un arreglo
clase.push(alumno);
clase.push(
    {
        Nombre: "Pedro",
        Apellidos: "Ruiz",
        Edad: 15,
        FechaNacimiento: new Date(),
    }
);

function MostrarAlumno() {
    //debugger;
    //Mostrar Mensaje
    alert("Es el alumno: "
        + (alumno.Nombre) + " " + (alumno.Apellidos));
}

function MostrarEstudiante() {
    //debugger;
    //Mostrar Mensaje
    alert("Es el alumno: "
        + alumno.GenerarNombreCompleto("M"));
}

function MostrarEstudiantes() {
    //Implementando una estructura condicional repetitiva
    for (var i = 0; i < clase.length; i++) {
        alert("Es el alumno: "
            + clase[i].GenerarNombreCompleto());
    }

}


 