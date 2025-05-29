"use strict";

let _divs = document.getElementsByTagName("div");
let _oraCorrente = _divs[0]
let _tempoTrascorso = _divs[1]
let _wrapper = _divs[2]
let _btnStop = document.getElementById("btnStop");
let _btnStart = document.getElementById("btnRestart");
_btnStop.disabled = true



// leggo le dimensioni wrapper
// alert(_wrapper.style.width)  // stringa vuota
let wrapper_w = getComputedStyle(_wrapper).width;
let wrapper_h = getComputedStyle(_wrapper).height;
// alert(wrapper_w) devo togliere il 'px' finale
wrapper_w = parseInt(wrapper_w.substring(0, wrapper_w.length - 2));
wrapper_h = parseInt(wrapper_h.substring(0, wrapper_h.length - 2));
let timerId;
console.log(wrapper_h, wrapper_w)
_btnStart.addEventListener("click", function () {
	_wrapper.innerHTML = "";
	timerId = setInterval(genera, 50);
	_btnStop.disabled = false;
	_btnStart.disabled = true;

})

_btnStop.addEventListener("click", function () {
	_btnStop.disabled = true;
	_btnStart.disabled = false;
	clearInterval(timerId);

})

function genera() {
	let div = document.createElement("div")
	//Genero dimensioni
	let w = generaNumero(1, 101)
	let h = generaNumero(1, 101)
	div.style.width = `${w}px`;
	div.style.height = `${h}px`;
	//Genero colori
	let red = generaNumero(0, 256)
	let green = generaNumero(0, 256)
	let blue = generaNumero(0, 256)
	let color = `rgb(${red},${green},${blue})`;
	div.style.backgroundColor = color;
	//Genera posizione 
	let x = generaNumero(0, wrapper_w - w + 1);
	let y = generaNumero(0, wrapper_h - h + 1);
	div.style.position = "absolute"
	div.style.left = `${x}px`;
	div.style.top = `${y}px`;
	_wrapper.appendChild(div);


}

function generaNumero(min, max) {
	let rnd = Math.floor((max - min) * Math.random()) + min;
	return rnd;
}