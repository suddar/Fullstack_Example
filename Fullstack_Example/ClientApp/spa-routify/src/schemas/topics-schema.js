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

export function updateTopicMutation(id, name) {
  return `mutation {
        updateTopic(id: ${id},name: "${name}") {
          id
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