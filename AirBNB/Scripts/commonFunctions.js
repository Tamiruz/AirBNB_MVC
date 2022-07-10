//Search apartments by filter.
function searchApartments() {
    let keyword = $('#keyword').val();
    let from = $('#from').val();
    let to = $('#to').val();
    let minP = $('#range-1').val();
    let maxP = $('#range-2').val();
    let minD = $('#range-3').val();
    let maxD = $('#range-4').val();
    let beds = $('#select-search-7').prop('selectedIndex');
    let rating = $('#select-search-8').prop('selectedIndex');
    filters = { keyword, from, to, minP, maxP, minD, maxD, beds, rating };
    if (keyword == "") keyword = "Any";
    if (beds == 0) beds = 1;
    if (rating == 0) rating = 1;

    if (validateDates(from, to) == false) {
        swal({ // this will open a dialouge
            title: "Your Dates is invalid",
            text: "Please enter again.",
            icon: "warning",
            button: true,
            dangerMode: true
        })
        return false;
    }


    localStorage.setItem('group101_filters', JSON.stringify(filters));

    let api = `../api/Apartments/search/${keyword}/${from}/${to}/${minP}/${maxP}/${minD}/${maxD}/${beds}/${rating}`;
    ajaxCall('GET', api, "", searchSCB, errorCB);

    return false;
}

// Validate dates.
function validateDates(checkIn, checkOut) {
    checkIn = new Date(checkIn); // time - 03:00:00
    checkOut = new Date(checkOut); // time - 03:00:00
    nowDate = new Date();
    nowDate.setHours(03); // time - 03:00:00


    let diffTime = (checkIn - checkOut);
    let diffDays = Math.ceil(diffTime / (1000 * 60 * 60 * 24));

    let diffTimeNow = (nowDate - checkIn);
    let diffDaysNow = Math.ceil(diffTimeNow / (1000 * 60 * 60 * 24)) - 1;

    if (diffDays >= 0)
        return false;
    else if (diffDaysNow > 0)
        return false;
    return true;
}


//Success CB function, the apartments that was found by filter will be shown in the grid catalog.
function searchSCB(apartments) {
    console.log(apartments);
    localStorage.setItem('group101_searchApartments', JSON.stringify(apartments)); // Send apartments results.
    localStorage.setItem('group101_index', JSON.stringify(0));                     // Send starting index.
    window.location = 'property-catalog-grid.html';
}
