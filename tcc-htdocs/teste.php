<script>
    function exemplo() {
        $.ajax({
            url: "exemplo.php",
            success: function(resultado) {
                console.log(resultado);
            },
            error: function() {
                console.log("Error");
            }
        });
    }
</script>





