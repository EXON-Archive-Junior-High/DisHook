var request = new XMLHttpRequest();
request.open("POST", "https://discordapp.com/api/webhooks/719835196135964672/x47I90Q-oUEDk6ctHyt3DgQywgMLT3eThXX7KCN_VALOgpL9i1swtjo5eywoKs293EFo");
// again, replace the url in the open method with yours
request.setRequestHeader('Content-type', 'application/json');

var myEmbed = {
    author: {
        name: "Captain Hook"
    },
    title: "My new embed",
    description: "This is a cool-looking Discord embed, sent directly from JavaScript!",
    color: hexToDecimal("#ff0000")
}

var params = {
    username: "My Webhook Name",
    embeds: [myEmbed]
}

request.send(JSON.stringify(params));

// function that converts a color HEX to a valid Discord color
function hexToDecimal(hex) {
    return parseInt(hex.replace("#", ""), 16)
}