var $input = document.getelementbyid('input-file'),
    $filename = document.getelementbyid('file-name');

$input.addeventlistener('change', function () {
    $filename.textcontent = this.value;
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah')
                .attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);

        console.log(reader.readAsDataURL());
    }
}