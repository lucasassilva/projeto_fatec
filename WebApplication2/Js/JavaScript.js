/****************************************
   SLIDE - PAGINA PRINCIPAL
*****************************************/
$(document).ready(function () {
    $('.flexslider').flexslider(
        {
            animation: "slide",
        });
});
/****************************************
   MASCARAS DOS CAMPOS - TRABALHE CONOSCO
*****************************************/
$(document).ready(function () {
    $('.DataNascimento').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/aaaa' })
    $('.Telefone').inputmask('(99)9999-9999', { 'placeholder': '(00)0000-0000' });
});
/****************************************
   CAMPO ARQUIVO(UPLOAD) - TRABALHE CONOSCO
*****************************************/
$(document).ready(function () {
    $('input[type="file"]').change(function (e) {
        const fileName = e.target.files[0].name;
        const error = document.querySelector(".Erro");
        const txtFileName = document.getElementById('filename');
        const form = document.querySelector("#form");
        const ext = fileName.split('.').pop();
        if (ext == "pdf" || ext == "docx" || ext == "doc") {
            if (txtFileName.value != "" && fileName.value != "") {
                if (txtFileName.value == null && fileName.value == null) {
                    error.innerHTML = "";
                    txtFileName.innerHTML = "<i class='fa fa-file'></i>" + "&nbsp" + fileName + "<button id ='fileNone'><i class='fa fa-close'></i></button>";
                    const fileNone = document.querySelector("#fileNone");
                    fileNone.style.width = "30px";
                    fileNone.style.height = "20px";
                    fileNone.style.padding = "0px";
                    fileNone.style.marginLeft = "10px";
                    fileNone.type = "button";
                    fileNone.onclick = function () {
                        filename.innerHTML = "";
                    }
                }
            }
        } else {
            error.innerHTML = "Falha no formato do arquivo";
            form.scrollIntoView({ behavior: "smooth", block: "start" });
        }
    });
});
/****************************************
   PORTFÓFLIO
*****************************************/
const modal = document.getElementById("myModal");
const modalImg = document.getElementById("image");
const captionText = document.getElementById("caption");
const image01 = document.querySelector("#image01");
const image02 = document.querySelector("#image02");
const image03 = document.querySelector("#image03");
const image04 = document.querySelector("#image04");
const image05 = document.querySelector("#image05");
const image06 = document.querySelector("#image06");
const image07 = document.querySelector("#image07");
const image08 = document.querySelector("#image08");
const image09 = document.querySelector("#image09");

$(document).ready(function () {
    $(image01).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image02).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image03).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image04).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image05).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image06).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image07).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image08).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
    $(image09).click(function () {
        modal.style.display = "block";
        modalImg.src = this.src;
        captionText.innerHTML = this.alt;
    });
});












