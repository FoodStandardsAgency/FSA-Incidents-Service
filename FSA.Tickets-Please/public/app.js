// IT's real classic
// https://stackoverflow.com/questions/901115/how-can-i-get-query-string-values-in-javascript
let urlParams = {};
(window.onpopstate = function () {
    let match, pl = /\+/g, // Regex for replacing addition symbol with a space
    search = /([^&=]+)=?([^&]*)/g, decode = function (s) {
        return decodeURIComponent(s.replace(pl, " "));
    }, query = window.location.search.substring(1);
    while (match = search.exec(query)) {
        if (decode(match[1]) in urlParams) {
            if (!Array.isArray(urlParams[decode(match[1])])) {
                urlParams[decode(match[1])] = [urlParams[decode(match[1])]];
            }
            urlParams[decode(match[1])].push(decode(match[2]));
        }
        else {
            urlParams[decode(match[1])] = decode(match[2]);
        }
    }
})();
function getCode() {
    if ((urlParams === null || urlParams === void 0 ? void 0 : urlParams.code) != null) {
        // get the access token
    }
    else {
        // get the auth code
        var clientId = document.getElementById("clientId").value;
        var tenantId = document.getElementById("tenantId").value;
        var redirectUri = document.getElementById("redirectUri").value;
        var url = "https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/authorize?client_id=" + clientId + "&response_type=code&redirect_uri=" + window.encodeURIComponent(redirectUri) + "&response_mode=query&scope=.default&state=12345";
        console.log(url);
        window.location.assign(url);
    }
}
function appStart() {
    var btn = document.getElementById("getTokenButton");
    btn.addEventListener("click", getCode);
    // is this code 
    var code = urlParams === null || urlParams === void 0 ? void 0 : urlParams.code;
    if (code)
        setMessage(code);
}
function setMessage(msg) {
    var msgBox = document.getElementById("msgBox");
    msgBox.innerHTML = msgBox.innerHTML + `<p>${msg}<br />`;
}
appStart();
//# sourceMappingURL=app.js.map