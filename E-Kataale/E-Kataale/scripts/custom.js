﻿$(document).ready(function () {
    "use strict";

    $(document).ready(function () {
        $('#example').DataTable();
       
        $('#example tr').each(function () {

            $(this).on('click', function (e) {

             

            });

        });

    });

    $('.dataTables_length').addClass('bs-select');


    var elem = $('.title strong');
    var body = $('body');
    var currentTargetIndex;
    var brandtitle = elem.text();
    var index = -1;
    var time = 0.05;

    $('.title strong').remove();

    for (i = 0; i < brandtitle.length; i++) {


        var title = '<span style="transition: color 0s ease ' + time + 's">' + brandtitle[i] + '</span>';


        $('.title').append(title);
        time += 0.02;



    }

    console.log(brandtitle);

    console.log($('.title').html());


    var i = 0;

    $('.title').on('mouseover', function () {

        console.log('e.innerText');


    });



});