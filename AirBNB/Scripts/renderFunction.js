function renderDescription(des, size) {
    let words = des.split(' ');
    if (size > words.length)
        size = words.length;
    let str = "";
    for (var i = 0; i < size; i++)
        str += words[i] + " ";
    str += "...";
    return str;
}


function renderPersons(num) { 
    let str = "";
    for (var i = num; i >= 1; i--)
        str += '<span class="mdi mdi-odnoklassniki"></span>';
    return str;
}

function renderStars(score, reviews) { 
    if (reviews > 0)
        str = "<p style='text-align:center'>" + score.toFixed(1) + ' (' + reviews + ')</p>';
    else str = "<p>" + score.toFixed(1) + '</p>';
    for (var i = score; i >= 1; i--) {
        str += '<span class="fa-star"></span>';
    }
    if (i > 0.5)
        str += '<span class="fa-star-half"></span>';
    return str;
}
function checkLogin() {

    $('#adminPages').hide();
    user = null;
    if (localStorage.getItem("group101_userLogged") != undefined) {
        user = JSON.parse(localStorage.getItem("group101_userLogged"));
        $('.userLogin').html("Hello " + user.Username);
        $('.sign').html("Logout");

        if ((user.Type).localeCompare('A')==0)
            $('#adminPages').show();
        return true;
    }
    else {
        $('#adminPages').hide();
        $('.userLogin').html("Hello Guest");
        $('.sign').html("Login/Registration");
        return false;
    }

}

//Rendering whether the host is verified.
function renderVerified(verified) {
    console.log(verified);
    let str = "";
    if (verified) str += '<span class="fa-check"></span>';
    else str += '<span class="fa-times"></span>';
    return str;
}

//Rendering the reviews by apartment ID.
function renderReviews(id) {
    api = `../api/Reviews/apartment/${id}`;
    ajaxCall("GET", api, "", reviewSCB, reviewECB);
}

