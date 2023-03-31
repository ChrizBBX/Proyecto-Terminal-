$(document).ready(function () {

    const $grafica = document.querySelector("#graficapai");
    const etiquetas = ["Mujer", "Hombre"]
    const Cantidad = [];


    $.ajax({
        url: '/Boleto/GraficaSexo',
        data: "",
        dataType: 'json',
        success: function (Grafica) {

            //Declaracion de los arrys
            var i = 0;
            var total = 0; // Variable para almacenar la cantidad total de valores

            // Agrega las opciones de municipios
            $.each(Grafica, function (index, GraficaS) {
                i++;
                Cantidad.push(GraficaS.femenino);
                Cantidad.push(GraficaS.masculino);

                total += GraficaS.femenino + GraficaS.masculino; // Calcula la cantidad total de valores
            });

            //Grafica
            const datosIngresos = {
                data: Cantidad,
                backgroundColor: [
                    'rgba(163,221,203,0.2)',
                    'rgba(232,233,161,0.2)',
                ],
                borderColor: [
                    'rgba(163,221,203,1)',
                    'rgba(232,233,161,1)',
                ],
                borderWidth: 1,
            };

            new Chart($grafica, {
                type: 'pie',
                data: {
                    labels: etiquetas,
                    datasets: [
                        datosIngresos,
                    ]
                },
                options: {
                    tooltips: {
                        callbacks: {
                            // Función para mostrar los porcentajes en los tooltips
                            label: function (tooltipItem, data) {

                                var value = data.datasets[0].data[tooltipItem.index];
                                var percent = (value / total * 100).toFixed(2);
                                return data.labels[tooltipItem.index] + ': ' + value + ' (' + percent + '%)';

                            }
                        }
                    }
                }
            });

        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('Error al cargar : ' + textStatus + ', ' + errorThrown);
        }
    });

});
