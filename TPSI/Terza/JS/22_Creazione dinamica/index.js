"use strict"
const wrapper = document.getElementById("wrapper");
const DIM = 10;
for(let i = 0; i < DIM; i++)
{
    
    for(let j = 0; j < DIM; j++)
    {
        let btn = document.createElement("button");
        wrapper.appendChild(btn);
        btn.classList.add("btnStyle");
        btn.id = `btn-${i}-${j}`;    
        btn.addEventListener("click", visualizza);    
    }
}

function visualizza()
{
    
    this.style.backgroundColor="#F00";
    this.disabled = true;
    let i = parseInt(this.id.split("-") [1]);
    let j = parseInt(this.id.split("-") [2]);
    this.textContent = `${i}-${j}`; 
    if(j < 9)
    {
        let btnDx = document.getElementById(`btn-${i}-${j+1}`);
        btnDx.style.backgroundColor="#0F0";
        btnDx.textContent = `${i}-${j}`;   
        btnDx.disabled = true; 
    }   

}