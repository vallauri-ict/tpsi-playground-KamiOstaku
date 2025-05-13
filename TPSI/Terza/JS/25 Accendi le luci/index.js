"use strict"

const GIALLO = "rgb(255, 255, 0)"
const GRIGIO = "rgb(160, 160, 160)"
const cmb = document.getElementsByTagName("select")[0];
const wrapper = document.getElementById("wrapper");

for(let i = 3; i < 7; i++)
{
    let option = document.createElement("option");
    option.value = i;
    option.textContent = `${i}x${i}`
    cmb.appendChild(option);
}

cmb.selectedIndex = -1;
cmb.addEventListener("change",function() 
{
    let dim = this.value;

    wrapper.style.width = `${dim*50}px`;
    wrapper.innerHTML = null;
    for(let i = 0; i < dim;i++)
    {
        for(let j = 0; j < dim;j++)
        {
            let div = document.createElement("div");
            wrapper.appendChild(div);

            div.classList.add("pedina");
            div.style.backgroundColor = GRIGIO;
            div.id = `${i},${j}`;
            div.addEventListener("click",cambiaColore);
        }
    }
});

function cambiaColore()
{
    const row = parseInt(this.id.split(",")[0]);
    const col = parseInt(this.id.split(",")[1]);

    accendiLucix(this.style.backgroundColor);

    if(row > 0)
    {
        let div = document.getElementById(`${row},${col}`);
    }
}

function accendiLucix(color)
{
    return color == GRIGIO? GIALLO : GRIGIO;
}

