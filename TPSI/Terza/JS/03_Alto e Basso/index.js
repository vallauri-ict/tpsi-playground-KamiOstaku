"use strict"
let nSegreto = generaNumero(1,101);
let _txtNumero = document.getElementById("txtNumero");
let _divMsg = document.getElementById("divMessaggio");
let _btnGioca = document.getElementById("btnGioca");
let _btnReset = document.getElementById("btnReset");
let cntTent = 0;
_btnReset.style.display = "none";
function generaNumero(min,max){
    /*formula per generare un numero 
    casuale compreso tra min e max max escluso */
    return Math.floor((max-min)*Math.random()+min);
}
function gioca ()
{
    let msg = "";
    let nUser = parseInt(_txtNumero.value);
    let win = false;
    if(nUser <1 || nUser >= 100 || _txtNumero.value === "" )
    {
        alert("numero non valido");
       
    }
    else
    {   
        cntTent++;
        divTries.textContent = "Tentativi: " + cntTent.toString();
        if(nUser > nSegreto)
        {
            msg = "numero inserito troppo grande " + nUser.toString();
        }
        else if(nUser < nSegreto)
        {
            msg = "numero inserito troppo piccolo " + nUser.toString();
        }
        else
        {
            msg = "Numero indovinato!";
            win = true;
            terminaGioco();
            if(!winb && cntTent >= 10)
            {
                msg += "<br> Hai perso, hai esaurito i tentativi. Il numero segreto era "+ nSegreto.toString();
                terminaGioco();
            }
            
        }
        _divMsg.innerHTML += msg + "<br>";
    }
    _txtNumero.value = " ";
    _txtNumero.focus();
}
function terminaGioco()
{
    _txtNumero.disabled = true;
    _btnGioca.disabled = true;
    _btnReset.style.display = "block";
}

function gestisciEnter(event)
{
    if(event.key == "Enter")
    {
        gioca();
    }
}

