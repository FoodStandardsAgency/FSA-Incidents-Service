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
        hashQuery  = window.location.hash.substring(1);

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
    if (urlParams?.code != null) {
        // get the access token
    }
    else {
        // get the auth code
        var clientId = (document.getElementById("clientId") as HTMLInputElement).value;
        var tenantId = (document.getElementById("tenantId") as HTMLInputElement).value;
        var redirectUri = (document.getElementById("redirectUri") as HTMLInputElement).value;
        var scopes = (document.getElementById("scopes") as HTMLInputElement).value;

        var url = "https://login.microsoftonline.com/" + tenantId + "/oauth2/v2.0/authorize?client_id=" + clientId + "&response_type=token&redirect_uri=" + window.encodeURIComponent(redirectUri) + "&response_mode=fragment&scope=" +  scopes +"&state=12345";
        console.log(url);

        window.location.assign(url);
    }
}

const getAccessToken = async (): Promise<string> => {
    // get the auth code
    var clientId = (document.getElementById("clientId") as HTMLInputElement).value
    var tenantId = (document.getElementById("tenantId") as HTMLInputElement).value
    var redirectUri = (document.getElementById("redirectUri") as HTMLInputElement).value
    var clientSecret = (document.getElementById("clientSecret") as HTMLInputElement).value
    var url = `https://login.microsoftonline.com/${tenantId}/oauth2/v2.0/token`;
    var body = {
        client_id: clientId,
        scope: ".default",
        redirect_uri: redirectUri,
        grant_type: "authorization_code",
        client_secret: clientSecret,
        code: urlParams.code
    }
    const toUrlEncoded = obj => Object.keys(obj).map(k => encodeURIComponent(k) + '=' + encodeURIComponent(obj[k])).join('&');
    var headers = new Headers();
    headers.append("Content-Type", 'application/x-www-form-urlencoded');


    var formData = new FormData();
    formData.append(" client_id",clientId);
    formData.append("scope", ".default");
    formData.append("redirect_uri", redirectUri);
    formData.append("grant_type", "authorization_code");
    formData.append("client_secret", clientSecret);
    formData.append("code", urlParams.code);



    var results = await fetch(url, { method: "Post", headers: headers, body: formData }) as any;
    //window.location.assign(url);
    console.log(results);
    return results.access_token;
}

const submitForm = async(e:any, formElem:HTMLFormElement) :Promise<void> =>{
    e.preventDefault();

    // formLogin.action = `https://login.microsoftonline.com/${tenantId}/oauth2/v2.0/token`

    var tenantId = (document.getElementById("tenantId") as HTMLInputElement).value
    let response = await fetch(`https://login.microsoftonline.com/${tenantId}/oauth2/v2.0/token`, {
        method: 'POST',
        body: new FormData(formElem)
      });
  
      let result = await response.json();
  
      alert(result.message);

}

function copyAcc(e:any)
{
    console.log(e.target.value);
    e.target.select();
    document.execCommand('copy');
}

const appStart = async (): Promise<void> => {
    var btn = document.getElementById("getTokenButton");
    var acc = (document.getElementById("tbAccessToken") as HTMLInputElement);
    acc.addEventListener("click", copyAcc)
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