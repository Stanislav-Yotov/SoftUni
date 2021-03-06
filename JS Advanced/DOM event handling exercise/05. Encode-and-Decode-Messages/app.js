function encodeAndDecodeMessages() {
    let buttons = document.getElementsByTagName('button');
    let encodeBtn = buttons[0];
    let decodeBtn = buttons[1];
    encodeBtn.addEventListener('click', onClickEncode);
    decodeBtn.addEventListener('click', onClickDecode);

    function onClickEncode(e){
        let messageToEncode = document.getElementsByTagName('textarea')[0];
        let result = document.getElementsByTagName('textarea')[1];
        let encodedMessage = encode(messageToEncode.value);

        result.value = encodedMessage;
        messageToEncode.value = '';
    }

    function onClickDecode(e){
        let messageToDecode = document.getElementsByTagName('textarea')[1];
        let decodedMessage = decode(messageToDecode.value);
        messageToDecode.value = decodedMessage;
    }

    function encode(msg){
        let newMsg = [];

        for (let i = 0; i < msg.length; i++) {
            let char = msg.charCodeAt(i);
            newMsg.push(String.fromCharCode(++char));
        }
        return newMsg.join('');
    }

    function decode(msg){
        let newMsg = [];

        for (let i = 0; i < msg.length; i++) {
            let char = msg.charCodeAt(i);
            newMsg.push(String.fromCharCode(--char));
        }
        return newMsg.join('');
    }
}