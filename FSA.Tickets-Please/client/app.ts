// IT's real classic
// https://stackoverflow.com/questions/901115/how-can-i-get-query-string-values-in-javascript
let urlParams = {} as any;
let hashParams = {} as any;
(window.onpopstate = function () {
    let match,
        pl = /\+/g,  // Regex for replacing addition symbol with a space
        search = /([^&=]+)=?([^&]*)/g,
        decode = function (s) {
            return decodeURIComponent(s.replace(pl, " "));
        },
        query = window.location.search.substring(1),
        hashQuery = window.location.hash.substring(1);

    while (match = search.exec(query)) {
        if (decode(match[1]) in urlParams) {
            if (!Array.isArray(urlParams[decode(match[1])])) {
                urlParams[decode(match[1])] = [urlParams[decode(match[1])]];
            }
            urlParams[decode(match[1])].push(decode(match[2]));
        } else {
            urlParams[decode(match[1])] = decode(match[2]);
        }
    }

    while (match = search.exec(hashQuery)) {
        if (decode(match[1]) in hashParams) {
            if (!Array.isArray(hashParams[decode(match[1])])) {
                hashParams[decode(match[1])] = [hashParams[decode(match[1])]];
            }
            hashParams[decode(match[1])].push(decode(match[2]));
        } else {
            hashParams[decode(match[1])] = decode(match[2]);
        }
    }


})();

function getCode() {
    // get the auth code
    var clientId = (document.getElementById("clientId") as HTMLInputElement).value;
    var tenantId = (document.getElementById("tenantId") as HTMLInputElement).value;
    var redirectUri = (document.getElementById("redirectUri") as HTMLInputElement).value;
    var scopes = (document.getElementById("scopes") as HTMLInputElement).value;

    var url = "https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/authorize?client_id=" + clientId + "&response_type=token&redirect_uri=" + window.encodeURIComponent(redirectUri) + "&response_mode=fragment&scope=" + scopes + "&state=12345";
    console.log(url);

    window.location.assign(url);

    var url2 = "https://login.microsoftonline.com/" + tenantId 
             + "/oauth2/v2.0/authorize?client_id=" + clientId 
             + "&response_type=id_token&redirect_uri=" + window.encodeURIComponent(redirectUri) 
             + "&response_mode=fragment&scope=" + scopes + "&state=12345&nonce=678910";
    console.log(url2);

    window.localStorage.setItem("pcl1", url2);
    window.location.assign(url);


}


function copyAcc(e: any) {
    console.log(e.target.value);
    e.target.select();
    document.execCommand('copy');
}

const appStart = async (): Promise<void> => {
    var btn = document.getElementById("getTokenButton");
    var acc = (document.getElementById("tbAccessToken") as HTMLInputElement);
    // Copies the access token into the clipboard
    acc.addEventListener("click", copyAcc)
    // Fetches the token for you.
    btn.addEventListener("click", getCode);

    // is this code 
    var accessToken = hashParams?.access_token;
    if (accessToken) {
        console.log(hashParams);

        setMessage("Got access Token");
        (document.getElementById("tbAccessToken") as HTMLInputElement).value = accessToken;
    }
}

function setMessage(msg: string) {
    var msgBox = document.getElementById("msgBox");
    msgBox.innerHTML = msgBox.innerHTML + `<p>${msg}<br />`;
}

appStart();