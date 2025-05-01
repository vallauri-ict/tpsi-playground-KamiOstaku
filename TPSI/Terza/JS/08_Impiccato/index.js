"use strict";

const nomi =
        ["Italia", "Lavagna", "Pizza", "Lasagne", "Spiedino", "Ananas", "Gnocchi", "Gorgonzola", "Broccoli", "Mango", "Biscotti", 
         "Giornale", "Carabina", "Affettati", "Lungimirante", "Affaticato", "Effervescente", "Ambulante", "Ambulanza", "Ostetricia"];
const MAX_TENTATIVI=5;
const  pos = random(1,nomi.length);
let parolaSegreta = nomi[pos];
const _txtParola  = document.getElementById("txtParola");
parolaSegreta = parolaSegreta.toUpperCase();
const _txtLettera = document.getElementById("txtLettera");

init();
console.log(parolaSegreta)
function init()
{
    for (let i = 0; i < parolaSegreta.length; i++) 
    {
        _txtParola.value += "*";
    }
}
function oleg (s, char, index){
	s.substring(0, index) + char + s.substring(index + 1);
} 
function elabora()
{
	parolaSegreta.includes(_txtLettera.value);
	for(let i = 0; i < parolaSegreta.length;i++)
	{
		if(parolaSegreta[i] == _txtLettera.value)
		{
			oleg()
		}
	}
}

function converti()
{
	_txtLettera.value = _txtLettera.value.toUpperCase();
}

function random(a, b){
    return Math.floor((b-a)*Math.random()) + a;
}