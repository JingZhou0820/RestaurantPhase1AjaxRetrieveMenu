/*picture slider*/
$('.carousel').carousel();
/*modal using angularJs*/
$(document).on("click", "#open-ModalDialog", function () {
    var foodName = $(this).data('foodname');
    var foodImage = $(this).data('foodimage');
    var foodprice = $(this).data('foodprice');
    var description = $(this).data('description');
    var restaurantid = $(this).data('resturantsid');
    $(".modal-body #imageArea").attr("src",".."+"/assets/"+restaurantid+"/"+foodImage)
    $(".modal-title").html(foodName);
    $(".modal-body #priceArea").html("Price: $" + foodprice);
    $(".modal-body #descriptionArea").html(description);
});
