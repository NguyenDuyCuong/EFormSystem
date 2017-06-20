import axios from 'axios'

export const state = () => ({
  authUser: null
})

export const mutations = {
  SET_USER: function (state, user) {
    state.authUser = user
  }
}

export const actions = {
  nuxtServerInit ({ commit }, { req }) {
    if (req.session && req.session.authUser) {
      commit('SET_USER', req.session.authUser)
    }
  },
  login ({ commit }, { username, password }) {
    var params = new URLSearchParams()
    params.append('username', 'value1')
    params.append('password', 'value2')
    return axios.post('http://localhost:61836/api/Authentication', JSON.stringify({
      username,
      password
    }))
    .then((res) => {
      commit('SET_USER', res.data)
    })
    .catch((error) => {
      alert(error)
      if (error.response.status === 401) {
        throw new Error('Bad credentials')
      }
    })
  },

  logout ({ commit }) {
    return axios.post('http://localhost:61836/api/Authentication')
    .then(() => {
      commit('SET_USER', null)
    })
  }

}
