"use strict"
let _lst = document.getElementById("lstSiti");
_lst.selectedIndex = -1;


function visualizza()
{
    let url = _lst.value;
    //Apre in una nuova scheda il sito desiderato
    window.open(url);

    //Apre nella scheda corrente il sito desiderato
    //window.location.href = url;
}