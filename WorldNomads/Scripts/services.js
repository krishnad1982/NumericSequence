
function getSequenceDetails(){
            var vals=$("#txtNumber").val();
        var url = '/Home/GetSequence/';
         $.ajax({
            url:url,
            data:{number:vals},
            dataType:"json",
            type:"GET",
            error:function(xhr, error){
                alert(xhr.status+" "+error);
            },
            success:function(data){
          
            $("#sequence").empty();
            $("#evenSequence").empty();
            $("#oddSequence").empty();
            $("#fibSequence").empty();
            $("#condSequence").empty();
            $("#sequence").append
                (
                    '<h3><u>Sequence</u></h3>'+
                    data.Sequence
                )
            $("#evenSequence").append
                (
                    '<h3><u>Even Sequence</u></h3>'+
                    data.EvenSequence
                )
            $("#oddSequence").append
                (
                    '<h3><u>Odd Sequence</u></h3>'+
                    data.OddSequence
                )
            $("#fibSequence").append
                (
                    '<h3><u>Fibonacci Sequence</u></h3>'+
                    data.FibonacciSequence
                )
            $("#condSequence").append
                (
                    '<h3><u>Conditional Sequence</u></h3>'+
                    data.GetSequenceWithCondition
                )
            }

         });
};
