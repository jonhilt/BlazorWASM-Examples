export async function renderDot(model, element) {

    var graphviz = d3.select(element)
        .graphviz()
        .logEvents(true);

    graphviz.renderDot(model);
}
