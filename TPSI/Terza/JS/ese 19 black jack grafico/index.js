"use strict";

let _cartaG;

window.onload=function(){
    let _btnG=document.getElementsByClassName("card")[0]
    _cartaG=document.getElementsByClassName("card")[1]
    let _btnB=document.getElementsByClassName("card")[2]
    let _cartaB=document.getElementsByClassName("card")[3]
	
	let _puntiG = document.getElementsByTagName("span")[0]
	let _puntiB = document.getElementsByTagName("span")[1]	
    let _assoG=document.getElementsByClassName("msgAsso")[0]
    let _assoB=document.getElementsByClassName("msgAsso")[1]
	
	let _chkG = _assoG.children[0]
	let _chkB = _assoB.children[0]

    /* ***************** Inizializzazioni ********************* */
    _assoG.style.visibility="hidden";
	_assoB.style.visibility="hidden";
	_btnG.style.opacity=0.5
	_btnB.style.opacity=0.5

    _cartaG.style.backgroundImage = "url(./img/a1.gif)";
}


function generaNumero(a, b){
    return Math.floor((b-a)*Math.random())+a
}