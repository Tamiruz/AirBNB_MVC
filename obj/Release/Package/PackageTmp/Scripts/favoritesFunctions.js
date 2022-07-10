//Add to favorites function
function addToFavorites() {
    if (checkLogin() == false) {
        swal({ // this will open a dialouge
            title: "You need to log in",
            text: "Press ok to log in.",
            icon: "warning",
            buttons: true,
            dangerMode: true
        })
            .then(function (ok) {
                if (ok) location.replace("login.html");
                else swal("You are not logged!");
            });
        return false;
    }

    if (localStorage.getItem("group101_apartmentId") != undefined)
        apartmentID = JSON.parse(localStorage.getItem("group101_apartmentId"));
    if (localStorage.getItem("group101_userLogged") != undefined)
        user = JSON.parse(localStorage.getItem("group101_userLogged"));

    let favorite = {
        UserId: user.Id,
        ApartmentId: apartmentID
    }

    //First we gonna check if the user has this apartment already in his favorites. --- we are checking at DAL 
    let api = `../api/Favorites/insertFavorite`;
    ajaxCall("POST", api, JSON.stringify(favorite), successFavoriteCB, errorCB);
}

//Success callback for success insertfavorite function
function successFavoriteCB(res) {
    console.log(res);
    if (res == 0) {
        swal({ // this will open a dialouge
            title: "This apartment already in your favorites",
            text: "Press Ok for delete from favorites.",
            icon: "warning",
            buttons: true,
            dangerMode: true
        })
            .then(function (ok) {
                if (ok) {
                    let favorite = {
                        UserId: user.Id,
                        ApartmentId: apartmentID
                    }
                    let api = `../api/Favorites/deleteFromFavorites`;
                    ajaxCall("DELETE", api, JSON.stringify(favorite), deleteFavoriteSCB, errorCB);
                }
            });
    }
    else {
        swal({ // this will open a dialouge
            title: "Added to favorites!",
            text: "",
            icon: "success",
            button: true,
            dangerMode: false
        })
    }

}

//Deleting from favorites and returning the new array.
function deleteFavoriteSCB(favorites) {
    console.log(favorites);
    swal({ // this will open a dialouge
        title: "Deleted successfully",
        text: "",
        icon: "success",
        button: true,
        dangerMode: false
    });
}

