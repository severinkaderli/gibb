/*
	Javascript Datei mit verschiedenen Scripts die ich für meine Seite benötige.
	Alle Scripts wurden von mir "Severin Kaderli" erstellt.
*/

//Ladet den Inhalt der angegebenen Datei
function loadContent(fileName){
	$("#contentwrapper").load("../content/" + fileName);

};

//Funktion für den Hovereffekt bei den Bildern
$(document).ready(function() {
	$(".imageHover").on("mouseenter", this, function(){
		window.image = $(this).attr("src");
		window.imageCut = image.slice(0, -21);
		window.imageSuffix = "_small_color.png";
		$(this).attr("src", window.imageCut + window.imageSuffix);
	}).on("mouseleave", this, function(){
		$(this).attr("src", window.image);
	});
})

//Funktion für den Hovereffekt bei Bildern nach einem Ajax-Call
$(document).ajaxComplete(function() {
	$(document).ready(function() {
		
		$(".imageHover").on("mouseenter", this, function(){
			window.image = $(this).attr("src");
			window.imageCut = image.slice(0, -21);
			window.imageSuffix = "_small_color.png";
			$(this).attr("src", window.imageCut + window.imageSuffix);
		}).on("mouseleave", this, function(){
			$(this).attr("src", window.image);
		});
	});
})