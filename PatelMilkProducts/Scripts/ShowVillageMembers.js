
function ShowMembers(village) {
   
         var vill = village.value;
    
         $("#getMembers").empty();
         $.ajax({
             type: 'POST',
             url: "GetVillageMembers",
             dataType: 'json',
             data: { VName: vill },
             success: function (vil) {
                 alert("Called");

                 // states contains the JSON formatted list
                 // of states passed from the controller
                 $.each(vil, function (i, member) {
                     $("#getMembers").append('<option value="'
                         + member['Id'] + '">'
                         + member['Name'] + "  " + member['FatherName'] + '</option>');

                 });
             },
             error: function (ex) {
                 alert('Failed to retrieve states.' + ex);
             }
         });
}
function Tester() {
    alert("Called Tester");
}
           
  