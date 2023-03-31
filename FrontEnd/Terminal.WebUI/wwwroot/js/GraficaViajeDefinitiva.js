$(document).ready(function () {

    const $grafica = document.querySelector("#grafica");
    var Departamento = [];
    var Cantidad = [];
    var Porcentaje = [];

    $.ajax({
        url: '/Boleto/GraficaViajes',
        data: "",
        dataType: 'json',
        success: function (Grafica) {

            //Declaracion de los arrys
            var i = 0;
            // Agrega las opciones de municipios
            $.each(Grafica, function (index, GraficaV) {
                i++;
                Departamento.push(GraficaV.bole_hora_Destino_Nombre);
                Cantidad.push(GraficaV.cantidad);
            });

            // Calcular porcentajes
            var suma = Cantidad.reduce((a, b) => a + b, 0);
            Porcentaje = Cantidad.map((c) => ((c / suma) * 100).toFixed(2));
            console.log("hola");
            //Grafica
            var datosVentas2020 = {
                label: "Los departamento que mas se Viajan  ",
                data: Cantidad,
                backgroundColor: 'rgba(54, 162, 235, 0.2)',
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1,
            };
            new Chart($grafica, {
                type: 'bar',
                data: {
                    labels: Departamento.map((d, i) => `${d} (${Porcentaje[i]}%)`),
                    datasets: [
                        datosVentas2020,
                    ]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }],
                    },
                }
            });
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar : ' + textStatus + ', ' + errorThrown);
        }
    });
});
