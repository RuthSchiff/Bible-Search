function formatResult(item) {
    return `
        <div class="result-item">
            <strong>חומש:</strong> ${item.sefer || "לא ידוע"}<br/>
            <strong>פרשה:</strong> ${item.parasha || "לא ידועה"}<br/>
            <strong>פרק:</strong> ${item.perek || "לא ידוע"}<br/>
            <strong>פסוק:</strong> ${item.pasuk || "לא ידוע"}<br/>
        </div>
    `;
}

function handleSearch(apiEndpoint, query) {
    if (!query) {
        alert("אנא הזן מילה לחיפוש!");
        return;
    }
    axios.get(apiEndpoint + query)
        .then(result => {
            const data = result.data;
            if (Array.isArray(data) && data.length > 0) {
                document.getElementById("results").innerHTML = data.map(formatResult).join('');
                document.getElementById("countResult").innerHTML = `תוצאות: ${data.length}`;
            } else {
                document.getElementById("results").innerHTML = "לא נמצאו תוצאות.";
                document.getElementById("countResult").innerHTML = "תוצאות: 0";
            }
        })
        .catch(error => {
            console.error(error);
            alert("אירעה שגיאה בביצוע החיפוש!");
        });
}

function SearchP() {
    const query = document.getElementById("Word").value.trim();
    handleSearch("https://localhost:7181/SearchTanach/getSearchResults/", query);
}

function SearchR() {
    const query = document.getElementById("Word").value.trim();
    handleSearch("https://localhost:7181/SearchTanach/getSearchRT/", query);
}

function conversion() {
    const query = document.getElementById("Word").value.trim();
    handleSearch("https://localhost:7181/SearchTanach/getSearchGimatriya/", query);
}
