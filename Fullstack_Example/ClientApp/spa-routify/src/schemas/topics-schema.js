export const topicsQuery = `{
    topics{
        name
        id
    }
}`;

export function addTopicMutation(name) {
    return `mutation {
        addTopic(name: "${name}") {
          name
          id
        }
      }`;
}

export function updateTopicMutation(name) {
    return `mutation {
        updateTopic(name: "${name}") {
          name
        }
      }`;
}

export function removeTopicMutation(id) {
    return `mutation {
        deleteTopic(id: ${id}) {
            name
        }
      }`;
}