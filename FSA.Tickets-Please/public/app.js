var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
// IT's real classic
// https://stackoverflow.com/questions/901115/how-can-i-get-query-string-values-in-javascript
let urlParams = {};
let hashParams = {};
(window.onpopstate = function () {
    let match, pl = /\+/g, // Regex for replacing addition symbol with a space
    search = /([^&=]+)=?([^&]*)/g, decode = function (s) {
        return decodeURIComponent(s.replace(pl, " "));
    }, query = window.location.search.substring(1), hashQuery = window.location.hash.substring(1);
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
    while (match = search.exec(hashQuery)) {
        if (decode(match[1]) in hashParams) {
            if (!Array.isArray(hashParams[decode(match[1])])) {
                hashParams[decode(match[1])] = [hashParams[decode(match[1])]];
            }
            hashParams[decode(match[1])].push(decode(match[2]));
        }
        else {
            hashParams[decode(match[1])] = decode(match[2]);
        }
    }
})();
function getCode() {
    // get the auth code
    var clientId = document.getElementById("clientId").value;
    var tenantId = document.getElementById("tenantId").value;
    var redirectUri = document.getElementById("redirectUri").value;
    var scopes = document.getElementById("scopes").value;
    var url = "https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/authorize?client_id=" + clientId + "&response_type=token&redirect_uri=" + window.encodeURIComponent(redirectUri) + "&response_mode=fragment&scope=" + scopes + "&state=12345";
    console.log(url);
    window.location.assign(url);
}
function copyAcc(e) {
    console.log(e.target.value);
    e.target.select();
    document.execCommand('copy');
}
const appStart = () => __awaiter(this, void 0, void 0, function* () {
    var btn = document.getElementById("getTokenButton");
    var acc = document.getElementById("tbAccessToken");
    // Copies the access token into the clipboard
    acc.addEventListener("click", copyAcc);
    // Fetches the token for you.
    btn.addEventListener("click", getCode);
    // is this code 
    var accessToken = hashParams === null || hashParams === void 0 ? void 0 : hashParams.access_token;
    if (accessToken) {
        console.log(hashParams);
        setMessage("Got access Token");
        document.getElementById("tbAccessToken").value = accessToken;
    }
});
function setMessage(msg) {
    var msgBox = document.getElementById("msgBox");
    msgBox.innerHTML = msgBox.innerHTML + `<p>${msg}<br />`;
}
appStart();
//# sourceMappingURL=app.js.map