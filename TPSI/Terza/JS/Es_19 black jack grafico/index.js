"use strict";
window.onload=function(){
    let _btnG=document.getElementsByClassName("card")[0]
    _btnG.addEventListener("mouseover",mouseOver);
    _btnG.addEventListener("mouseout",mouseOut);
    let _cartaG=document.getElementsByClassName("card")[1]
    let _btnB=document.getElementsByClassName("card")[2]
    _btnB.addEventListener("mouseover",mouseOver);
    _btnB.addEventListener("mouseout",mouseOut);
    let _cartaB=document.getElementsByClassName("card")[3]
	
	let _puntiG = document.getElementsByTagName("span")[0]
	let _puntiB = document.getElementsByTagName("span")[1]	
    let _assoG=document.getElementsByClassName("msgAsso")[0]
    let _assoB=document.getElementsByClassName("msgAsso")[1]
	
	let _chkG = _assoG.children[0]
	let _chkB = _assoB.children[0]

    _btnG.addEventListener("click",() =>
		{
			let x = generaCarta(_cartaG,_assoG,_chkG);
            _puntiG.textContent = x+ parseInt(_puntiG.textContent);
		});

    /* ***************** Inizializzazioni ********************* */
    _cartaG.style.backgroundImage = "";
    _cartaB.style.backgroundImage = "";
    _assoG.style.visibility="hidden";
	_assoB.style.visibility="hidden";
    _btnG.style.opacity=0.5;
	_btnB.style.opacity=0.5;
}

function generaCarta(_pointer,_pointer2,_pointer3)
{
    let s,n;
    let sb = _pointer.style.backgroundImage.substring(11,12);
    let nb = _pointer.style.backgroundImage.substring(2,3);
    do
    {
        s = generaNumero(1,14);
        n = generaNumero(97,101);
    }while(s === sb && nb === n);

    _pointer.style.backgroundImage = "url(./img/" + String.fromCharCode(n) + s.toString() + ".gif)";

    if(s  == "1")
    {
        _pointer2.style.visibility="visible";
    }
    else
	{
		_pointer2.style.visibility="hidden";
	}

    return parseInt(s);
}

function mouseOver()
{
    this.style.opacity=1;
}
function mouseOut()
{
    this.style.opacity=0.5;
}

function generaNumero(a, b){
    return Math.floor((b-a)*Math.random())+a
}