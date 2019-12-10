$(document). ready(function(){
	$("item.cnpj").focusout(function(){
		var cnpj = $("item.cnpj").val();
		cnpj = cnpj.replace(".", "");
		var urlStr = "https://www.receitaws.com.br/v1/cnpj/"+ cnpj"

		$.ajax({
			url: urlStr,
			type: "get",
			dataType: "json",
			success: function(data){
				console.log(data);
				$("item.nome").val(data.nome);
				$("item.logradouro").val(data.logradouro);
				$("item.qsa").val(data.qsa);
			},
			error: function(erro){
				console.log(erro);
			}
		})
	});
});