

window.onload = function () {


    //window.alert("Page loaded");

   

};





function AddInfo1() {

    const d = new Date();
    let currentyear = d.getFullYear();

    // get the date tag element from HTML
    const dateTag = document.getElementById("dbstd");

    // get the date value from the date tag element
    const dateValue = dateTag.value;

    // create a new Date object with the date value
    const dateObj = new Date(dateValue);

    // extract the year from the date object
    const year = dateObj.getFullYear();

    // log the year to the console
   
    let resultyr = currentyear - year;
   // console.log(resultyr);



    if (document.getElementById("fnstd").value == "" || document.getElementById("lnstd").value == "" ||
        document.getElementById("fnprt").value == "" || document.getElementById("lnprt").value == "" ||
        !(document.getElementById("dbstd").value) || !(document.getElementById("rl").value)) {

        alert("Pleae fill all the required fields on page");

    }
    else if (resultyr > 18) {
        window.alert("Age of student should be less than 18")
    }
    else if (resultyr < 5) {
        window.alert("Age of student should be Greater than 5")
    }

    else {
        var element = document.getElementById("page1");
        element.style.display = "none";



        var element1 = document.getElementById("page2");
        element1.style.display = "block";

        document.getElementById("nmstd").textContent = "Student Name: " + document.getElementById("fnstd").value + " " + document.getElementById("lnstd").value;
        document.getElementById("nmprt").innerHTML = "Parent Name: " + document.getElementById("fnprt").value + " " + document.getElementById("lnprt").value;
        document.getElementById("hagestd").innerHTML = "Student Age: " + resultyr+" yrs";
        
    }
    //var stddb = document.getElementById("dbstd").value;
    //var age = today.getFullYear() - stddb.getFullYear();

    //document.getElementById("hagestd").innerHTML = "Student Age: " + age;

}

function AddInfo2() {


    const d = new Date();
    let currentyear = d.getFullYear();

    // get the date tag element from HTML
    const dateTag = document.getElementById("dbprt");

    const dateTag1 = document.getElementById("dbstd");

    // get the date value from the date tag element
    const dateValue = dateTag.value;
    const dateValue1 = dateTag1.value;

    // create a new Date object with the date value
    const dateObj = new Date(dateValue);
    const dateObj1 = new Date(dateValue1);

    // extract the year from the date object
    const year = dateObj.getFullYear();
    const year1 = dateObj1.getFullYear();

    // log the year to the console

    let resultyr = currentyear - year;
   // console.log(resultyr);
    let resultyr1 = currentyear - year1;

    let ocp = document.getElementById("ocprt").value;
    ocp = ocp.toUpperCase();


    if (document.getElementById("dbprt").value == "" ||
        !(document.getElementById("dbprt").value) || (document.getElementById("ocprt").value == "")) {

        alert("Pleae fill all the required fields on page");

    }
    else if (ocp == "CRIMINAL") {
        window.alert("Parent can not be a Criminal!!")
    }

    else if (resultyr > 60) {
        window.alert("Age of Parent should be less than 60")
    }


    else
    {

        var element = document.getElementById("page2");
        element.style.display = "none";


        var element1 = document.getElementById("page3");
        element1.style.display = "block";


        document.getElementById("nmstd1").textContent = "Student Name: " + document.getElementById("fnstd").value + " " + document.getElementById("lnstd").value;
        document.getElementById("nmprt1").innerHTML = "Parent Name: " + document.getElementById("fnprt").value + " " + document.getElementById("lnprt").value;
        document.getElementById("ocpprt").innerHTML = "Parent Occupation: " + document.getElementById("ocprt").value;
        document.getElementById("hagestd1").innerHTML = "Student Age: " + resultyr1+" yrs";
        document.getElementById("hageprt").innerHTML = "Parent Age: " + resultyr+" yrs";
    }

   
}






function AddStd() {

    var StudentId = $('#studentid').val();
    var FirstName = $('#fnstd').val();
    var LastName = $('#lnstd').val();
    var StudentDOB = $('#dbstd').val();
    var RelationWithStudent = $('#rl').val();
    var PFirstName = $('#fnprt').val();
    var PLastName = $('#lnprt').val();

    var ParentDOB = $('#dbprt').val();
    var Occupation = $('#ocprt').val();

    var Standard = $('#stdst').val();
    var PreviousYearPercentage = $('#stdpyper').val();
    var Gender = $('#gd').val();


    //var ProfileImage = $('#fileinput')[0].files[0];
    var ProfileImage = $('#fileinput').prop('files');

    var ProfileImagePath ="";

    
   // var Sports = $('#id').val();

    //var ProfileImage = $('#fileinput').val();

 //   var Id = $('#id').val();


   // let obj = new Object();

    var obj = {
        Student: {
            StudentId: StudentId,
            FirstName: FirstName,
            LastName: LastName,
            StudentDOB: StudentDOB,
            RelationWithStudent: RelationWithStudent,
            Gender: Gender,
            Standard: Standard,
            PreviousYearPercentage: PreviousYearPercentage,
            ProfileImage: ProfileImage,
            ProfileImagePath:""
          //  Sports: Sports
           
        },

        Parent: {
            PFirstName: PFirstName,
            PLastName: PLastName,
            ParentDOB: ParentDOB,
            Occupation: Occupation
        },


        Sport:
        {
          Id:1,
         SportName: ""
        }
    };


    //obj.Student.StudentId = StudentId;
    //obj.Student.FirstName = FirstName;
    //obj.Student.LastName = LastName;
    //obj.Student.StudentDOB = StudentDOB;
    //obj.Student.RelationWithStudent = RelationWithStudent;

    //obj.Parent.PFirstName = PFirstName;
    //obj.Parent.PLastName = PLastName;

    //obj.Parent.ParentDOB = ParentDOB;
    //obj.Parent.Occupation = Occupation;

    //obj.Student.Standard = Standard;
    //obj.Student.PreviousYearPercentage = PreviousYearPercentage;
    //obj.Student.Gender = Gender;

    //obj.Sports.Sports = Sports;

    //****************
    //obj.StudentId = StudentId;
    //obj.FirstName = FirstName;
    //obj.LastName = LastName;
    //obj.StudentDOB = StudentDOB;
    //obj.RelationWithStudent = RelationWithStudent;

    //obj.PFirstName = PFirstName;
    //obj.PLastName = PLastName;

    //obj.ParentDOB = ParentDOB;
    //obj.Occupation = Occupation;

    //obj.Standard = Standard;
    //obj.PreviousYearPercentage = PreviousYearPercentage;
    //obj.Gender = Gender;

    //obj.Sports = Sports;

    Submit(obj);

}


function Submit(obj) {
    var obj1 =
    {
        obj: obj
    };


    //var formData = new FormData();
    //formData.append('ProfileImage', $('#fileinput').prop('files')[0]);
    //formData.append('obj', JSON.stringify(obj));

    $.ajax({

        type: 'POST',
        url: '/Student/Add',
        data: obj1,
        processData: false,
        contentType: false,
      


        //dataType: 'json',
        //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
      

        success: function () {

            alert("Student Added Successfully!!");
            $("#exampleModal").hide();
            $(".modal-backdrop").remove();

            //$.get("/Student/Index", function (data) {
            //    $("body").html(data);
            //});


            // $("#empdata").load("Employee/Index");
        },

        error: function () {
            alert("Something went Wrorng!!");
        }

    });

}