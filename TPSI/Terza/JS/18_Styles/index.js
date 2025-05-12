"use strict"
let _body = document.getElementsByTagName("body")[0];
let _titolo = document.getElementById("titolo");
let _btnColore = document.getElementById("btnColore");
let _txtSize = document.getElementById("txtSize");
let _btnDimensione = document.getElementById("btnDimensione");
let _btnSfondo = document.getElementById("btnSfondo");
let _btnBordo = document.getElementById("btnBordo");
let _btnImg = document.getElementsByClassName("image");
let _imgBox = document.getElementById("imgBox");
let _btnClear = document.getElementById("btnClear");



_titolo.dataset.mioSfondo = "blu";
_titolo.dataset.bordo = "rosso";

_btnColore.addEventListener("click", function()
{
    //Il primo console.log resistuisce stringa vuota perchè legge solo valori dinamici
    console.log(_titolo.style.color,_titolo.style.backgroundColor)
    console.log(getComputedStyle(_titolo).color, getComputedStyle(_titolo).backgroundColor);
    if(_titolo.dataset.mioSfondo == "blu")
    {
        _titolo.dataset.mioSfondo = "giallo";
        _titolo.style.backgroundColor = "yellow";
        _titolo.style.color = "blue";

    }
    else 
    {
        _titolo.dataset.mioSfondo = "blu";
        _titolo.style.backgroundColor = "blue";
        _titolo.style.color = "yellow";   
    }

}
);
_btnDimensione.addEventListener("click", function()
{
    if(parseInt(_txtSize.value) > 45)
    {
        alert("inserisci un numero più piccolo di 45!!!")
    }
    else 
    {
        _titolo.style.fontSize = _txtSize.value + "pt";

    }
}
);
_btnSfondo.addEventListener("click", function()
{
    console.log(_body.style.background)
    if(_body.style.background == "")
    {
        _body.style.background ="#eaeaea url(./img/bg.gif) center repeat-y";
    }
    else 
    {
        _body.style.background = "";

    }
}   
);
_btnBordo.addEventListener("click", function()
{
    if(_titolo.dataset.bordo == "rosso")
    {
        _titolo.dataset.bordo = "bianco";
        _titolo.style.borderColor = "white";

    }
    else 
    {
        _titolo.dataset.bordo = "rosso";
        _titolo.style.borderColor = "red";  
    }
}   
);
for(let button of _btnImg)
{
    button.addEventListener("click", function()
    {
        let img = this.value;
        _imgBox.src="./img/" + img + ".jpg";
        _btnClear.disabled = false;
        
    }
    );
}
_btnClear.addEventListener("click", function()
{
    console.log("display: ", _imgBox.style.display)
    
    if(_imgBox.style.display == "" || _imgBox.style.display=="block")
    {
        _imgBox.style.display = "none";
        this.value="Visualizza";
    }
    else if(_imgBox.style.display == "none")
    {
        _imgBox.style.display = "block";
        this.value="Nascondi";
    }
         
}
);